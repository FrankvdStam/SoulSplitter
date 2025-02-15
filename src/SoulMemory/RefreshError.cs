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
using System.Text;

namespace SoulMemory;

public class RefreshError
{
    public static ResultErr<RefreshError> FromException(Exception e)
    {
        return Result.Err(new RefreshError(RefreshErrorReason.UnknownException, e));
    }

    public RefreshError(RefreshErrorReason reason)
    {
        Reason = reason;
    }

    public RefreshError(RefreshErrorReason reason, string message)
    {
        Reason = reason;
        Message = message;
    }

    public RefreshError(RefreshErrorReason reason, Exception exception)
    {
        Reason = reason;
        Exception = exception;
    }

    public RefreshErrorReason Reason { get; }
    public string Message { get; } = null!;
    public Exception? Exception { get; }

    public override string ToString()
    {
        var sb = new StringBuilder(Reason.ToString());
        if (!string.IsNullOrWhiteSpace(Message))
        {
            sb.Append(" - ");
            sb.Append(Message);
        }
        if (Exception != null)
        {
            sb.Append(" - ");
            sb.Append(Exception);
        }

        return sb.ToString();
    }
}

public enum RefreshErrorReason
{
    UnknownException,
    ScansFailed,
    ProcessNotRunning,
    ProcessExited,
    MainModuleNull,
    AccessDenied,
    ModLoadFailed
}
