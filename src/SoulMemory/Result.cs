// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
// Copyright (c) 2022 Frank van der Stam.
// https://github.com/FrankvdStam/SoulSplitter/blob/main/LICENSE
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, version 3.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

using System;

namespace SoulMemory
{
    /// <summary>
    /// Result. Can be Ok or can be Err.
    /// Can be Unwrapped - this will throw when the result is Err
    /// </summary>
    public class Result
    {
        #region Sugar interface ==========================================================================================================================================================

        public static ContainerOk<Empty> Ok()
        {
            return new ContainerOk<Empty>(default);
        }

        public static ContainerErr<Empty> Err()
        {
            return new ContainerErr<Empty>(default);
        }

        public static ContainerOk<T> Ok<T>(T t)
        {
            return new ContainerOk<T>(t);
        }

        public static ContainerErr<T> Err<T>(T t)
        {
            return new ContainerErr<T>(t);
        }

        //Ugly helper function to support old style errors for the webservice.
        //Should ultimately be removed after errors have been standardized
        public static ContainerErr<WebserviceError> WsErr(int code, string message)
        {
            return new ContainerErr<WebserviceError>(new WebserviceError(code, message));
        }

        #endregion

        public bool IsOk { get; protected set; }
        public bool IsErr => !IsOk;

        protected Result(bool ok)
        {
            IsOk = ok;
        }

        public static implicit operator Result(ContainerOk<Empty> ok)
        {
            return new Result(true);
        }

        public static implicit operator Result(ContainerErr<Empty> err)
        {
            return new Result(false);
        }

        public static implicit operator bool(Result result)
        {
            return result.IsOk;
        }

        public void Unwrap()
        {
            if (!IsOk)
            {
                throw new Exception("Called unwrap on a failed Result");
            }
        }

        public override string ToString()
        {
            return IsOk ? "Ok" : "Err";
        }
    }

    /// <summary>
    /// Result with generic error type.
    /// </summary>
    /// <typeparam name="TErr"></typeparam>
    public class ResultErr<TErr>
    {
        private readonly TErr _err;
        public bool IsOk { get; protected set; }
        public bool IsErr => !IsOk;

        protected ResultErr(bool isOk, TErr err)
        {
            IsOk = isOk;
            _err = err;
        }

        private ResultErr()
        {
            IsOk = true;
            _err = default;
        }

        private ResultErr(TErr err)
        {
            IsOk = false;
            _err = err;
        }

        public static implicit operator ResultErr<TErr>(ContainerOk<Empty> ok)
        {
            return new ResultErr<TErr>();
        }

        public static implicit operator ResultErr<TErr>(ContainerErr<TErr> err)
        {
            return new ResultErr<TErr>(err.Value);
        }

        public static implicit operator bool(ResultErr<TErr> resultErr)
        {
            return resultErr.IsOk;
        }

        public void Unwrap()
        {
            if (!IsOk)
            {
                throw new Exception("Called unwrap on a failed Result");
            }
        }

        public TErr GetErr()
        {
            if (IsOk)
            {
                return default;
            }
            return _err;
        }

        public override string ToString()
        {
            return IsOk ? $"Ok" : $"Err {typeof(TErr)}";
        }
    }

    /// <summary>
    /// Result with generic ok type.
    /// </summary>
    public class ResultOk<TOk>
    {
        private readonly TOk _ok;
        public bool IsOk { get; protected set; }
        public bool IsErr => !IsOk;

        protected ResultOk(bool isOk, TOk ok)
        {
            IsOk = isOk;
            _ok = ok;
        }

        private ResultOk()
        {
            IsOk = false;
            _ok = default;
        }

        private ResultOk(TOk ok)
        {
            IsOk = true;
            _ok = ok;
        }

        public static implicit operator ResultOk<TOk>(ContainerOk<TOk> ok)
        {
            return new ResultOk<TOk>(ok.Value);
        }

        public static implicit operator ResultOk<TOk>(ContainerErr<Empty> err)
        {
            return new ResultOk<TOk>();
        }

        public static implicit operator bool(ResultOk<TOk> resultOk)
        {
            return resultOk.IsOk;
        }

        public TOk Unwrap()
        {
            if (!IsOk)
            {
                throw new Exception("Called unwrap on a failed Result");
            }

            return _ok;
        }

        public override string ToString()
        {
            return IsOk ? $"Ok {typeof(TOk)}" : $"Err";
        }
    }

    /// <summary>
    /// Result type with generic Ok and Error type
    /// </summary>
    public class Result<TOk, TErr>
    {
        private readonly TOk _ok;
        private readonly TErr _err;
        public bool IsOk { get; protected set; }
        public bool IsErr => !IsOk;

        protected Result(bool isOk, TOk ok, TErr err)
        {
            IsOk = isOk;
            _ok = ok;
            _err = err;
        }

        private Result(TOk ok)
        {
            IsOk = true;
            _ok = ok;
            _err = default;
        }

        private Result(TErr err)
        {
            IsOk = false;
            _ok = default;
            _err = err;
        }

        public static implicit operator Result<TOk, TErr>(ContainerOk<TOk> ok)
        {
            return new Result<TOk, TErr>(ok.Value);
        }

        public static implicit operator Result<TOk, TErr>(ContainerErr<TErr> err)
        {
            return new Result<TOk, TErr>(err.Value);
        }

        public static implicit operator Result<TOk, TErr>(ResultOk<TOk> resultOk)
        {
            if (resultOk.IsOk)
            {
                return new Result<TOk, TErr>(true, resultOk.Unwrap(), default);
            }
            else
            {
                return new Result<TOk, TErr>(false, default, default);
            }
        }

        public static implicit operator Result<TOk, TErr>(ResultErr<TErr> resultErr)
        {
            if (resultErr.IsOk)
            {
                return new Result<TOk, TErr>(true, default, default);
            }
            else
            {
                return new Result<TOk, TErr>(false, default, resultErr.GetErr());
            }
        }

        public static implicit operator bool(Result<TOk, TErr> result)
        {
            return result.IsOk;
        }

        public TOk Unwrap()
        {
            if (IsOk)
            {
                return _ok;
            }
            throw new Exception("Called unwrap on a failed Result");
        }

        public TErr GetErr()
        {
            if (IsOk)
            {
                return default;
            }
            return _err;
        }

        public void Handle(Action<TOk> okAction, Action<TErr> errAction)
        {
            if (IsOk)
            {
                okAction(_ok);
            }
            else
            {
                errAction(_err);
            }
        }

        public override string ToString()
        {
            return IsOk ? $"Ok {typeof(TOk)}" : $"Err {typeof(TErr)}";
        }
    }


    /// <summary>
    /// Container type, used in implicit conversions with the Result classes, for sugar syntax.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Container<T>
    {
        public T Value;

        public Container(T t)
        {
            Value = t;
        }

        public override string ToString()
        {
            return $"{typeof(T)}";
        }
    }

    /// <summary>
    /// Container type for Ok, used to distinguish between Ok and Err in implicit conversions between result types.
    /// </summary>
    public class ContainerOk<T> : Container<T> { public ContainerOk(T t) : base(t) { } }

    /// <summary>
    /// Container type for Err, used to distinguish between Ok and Err in implicit conversions between result types.
    /// </summary>
    public class ContainerErr<T> : Container<T> { public ContainerErr(T t) : base(t) { } }

    /// <summary>
    /// Helper struct with 0 storage. Only used to trick the type system into allowing some sugar syntax
    /// </summary>
    public struct Empty { }

    /// <summary>
    /// Helper struct to help remove servicemodel exceptions from the other layers of the application,
    /// While keeping all the fields intact
    /// </summary>
    public struct WebserviceError
    {
        public WebserviceError(int code, string message)
        {
            Code = code;
            Message = message;
        }

        public int Code;
        public string Message;
    }
}