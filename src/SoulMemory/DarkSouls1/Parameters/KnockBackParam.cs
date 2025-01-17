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

using SoulMemory.Memory;
using SoulMemory.Parameters;
using System.Diagnostics.CodeAnalysis;

namespace SoulMemory.DarkSouls1.Parameters
{
    [ExcludeFromCodeCoverage]
    public class KnockBackParam : BaseParam
    {
        public KnockBackParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

        [ParamField(0x0, ParamType.F32)]
        public float Damage_Min_ContTime
        {
            get => _Damage_Min_ContTime;
            set => WriteParamField(ref _Damage_Min_ContTime, value);
        }
        private float _Damage_Min_ContTime;

        [ParamField(0x4, ParamType.F32)]
        public float Damage_S_ContTime
        {
            get => _Damage_S_ContTime;
            set => WriteParamField(ref _Damage_S_ContTime, value);
        }
        private float _Damage_S_ContTime;

        [ParamField(0x8, ParamType.F32)]
        public float Damage_M_ContTime
        {
            get => _Damage_M_ContTime;
            set => WriteParamField(ref _Damage_M_ContTime, value);
        }
        private float _Damage_M_ContTime;

        [ParamField(0xC, ParamType.F32)]
        public float Damage_L_ContTime
        {
            get => _Damage_L_ContTime;
            set => WriteParamField(ref _Damage_L_ContTime, value);
        }
        private float _Damage_L_ContTime;

        [ParamField(0x10, ParamType.F32)]
        public float Damage_BlowS_ContTime
        {
            get => _Damage_BlowS_ContTime;
            set => WriteParamField(ref _Damage_BlowS_ContTime, value);
        }
        private float _Damage_BlowS_ContTime;

        [ParamField(0x14, ParamType.F32)]
        public float Damage_BlowM_ContTime
        {
            get => _Damage_BlowM_ContTime;
            set => WriteParamField(ref _Damage_BlowM_ContTime, value);
        }
        private float _Damage_BlowM_ContTime;

        [ParamField(0x18, ParamType.F32)]
        public float Damage_Strike_ContTime
        {
            get => _Damage_Strike_ContTime;
            set => WriteParamField(ref _Damage_Strike_ContTime, value);
        }
        private float _Damage_Strike_ContTime;

        [ParamField(0x1C, ParamType.F32)]
        public float Damage_Uppercut_ContTime
        {
            get => _Damage_Uppercut_ContTime;
            set => WriteParamField(ref _Damage_Uppercut_ContTime, value);
        }
        private float _Damage_Uppercut_ContTime;

        [ParamField(0x20, ParamType.F32)]
        public float Damage_Push_ContTime
        {
            get => _Damage_Push_ContTime;
            set => WriteParamField(ref _Damage_Push_ContTime, value);
        }
        private float _Damage_Push_ContTime;

        [ParamField(0x24, ParamType.F32)]
        public float Damage_Breath_ContTime
        {
            get => _Damage_Breath_ContTime;
            set => WriteParamField(ref _Damage_Breath_ContTime, value);
        }
        private float _Damage_Breath_ContTime;

        [ParamField(0x28, ParamType.F32)]
        public float Damage_HeadShot_ContTime
        {
            get => _Damage_HeadShot_ContTime;
            set => WriteParamField(ref _Damage_HeadShot_ContTime, value);
        }
        private float _Damage_HeadShot_ContTime;

        [ParamField(0x2C, ParamType.F32)]
        public float Guard_S_ContTime
        {
            get => _Guard_S_ContTime;
            set => WriteParamField(ref _Guard_S_ContTime, value);
        }
        private float _Guard_S_ContTime;

        [ParamField(0x30, ParamType.F32)]
        public float Guard_L_ContTime
        {
            get => _Guard_L_ContTime;
            set => WriteParamField(ref _Guard_L_ContTime, value);
        }
        private float _Guard_L_ContTime;

        [ParamField(0x34, ParamType.F32)]
        public float Guard_LL_ContTime
        {
            get => _Guard_LL_ContTime;
            set => WriteParamField(ref _Guard_LL_ContTime, value);
        }
        private float _Guard_LL_ContTime;

        [ParamField(0x38, ParamType.F32)]
        public float GuardBrake_ContTime
        {
            get => _GuardBrake_ContTime;
            set => WriteParamField(ref _GuardBrake_ContTime, value);
        }
        private float _GuardBrake_ContTime;

        [ParamField(0x3C, ParamType.F32)]
        public float Damage_Min_DecTime
        {
            get => _Damage_Min_DecTime;
            set => WriteParamField(ref _Damage_Min_DecTime, value);
        }
        private float _Damage_Min_DecTime;

        [ParamField(0x40, ParamType.F32)]
        public float Damage_S_DecTime
        {
            get => _Damage_S_DecTime;
            set => WriteParamField(ref _Damage_S_DecTime, value);
        }
        private float _Damage_S_DecTime;

        [ParamField(0x44, ParamType.F32)]
        public float Damage_M_DecTime
        {
            get => _Damage_M_DecTime;
            set => WriteParamField(ref _Damage_M_DecTime, value);
        }
        private float _Damage_M_DecTime;

        [ParamField(0x48, ParamType.F32)]
        public float Damage_L_DecTime
        {
            get => _Damage_L_DecTime;
            set => WriteParamField(ref _Damage_L_DecTime, value);
        }
        private float _Damage_L_DecTime;

        [ParamField(0x4C, ParamType.F32)]
        public float Damage_BlowS_DecTime
        {
            get => _Damage_BlowS_DecTime;
            set => WriteParamField(ref _Damage_BlowS_DecTime, value);
        }
        private float _Damage_BlowS_DecTime;

        [ParamField(0x50, ParamType.F32)]
        public float Damage_BlowM_DecTime
        {
            get => _Damage_BlowM_DecTime;
            set => WriteParamField(ref _Damage_BlowM_DecTime, value);
        }
        private float _Damage_BlowM_DecTime;

        [ParamField(0x54, ParamType.F32)]
        public float Damage_Strike_DecTime
        {
            get => _Damage_Strike_DecTime;
            set => WriteParamField(ref _Damage_Strike_DecTime, value);
        }
        private float _Damage_Strike_DecTime;

        [ParamField(0x58, ParamType.F32)]
        public float Damage_Uppercut_DecTime
        {
            get => _Damage_Uppercut_DecTime;
            set => WriteParamField(ref _Damage_Uppercut_DecTime, value);
        }
        private float _Damage_Uppercut_DecTime;

        [ParamField(0x5C, ParamType.F32)]
        public float Damage_Push_DecTime
        {
            get => _Damage_Push_DecTime;
            set => WriteParamField(ref _Damage_Push_DecTime, value);
        }
        private float _Damage_Push_DecTime;

        [ParamField(0x60, ParamType.F32)]
        public float Damage_Breath_DecTime
        {
            get => _Damage_Breath_DecTime;
            set => WriteParamField(ref _Damage_Breath_DecTime, value);
        }
        private float _Damage_Breath_DecTime;

        [ParamField(0x64, ParamType.F32)]
        public float Damage_HeadShot_DecTime
        {
            get => _Damage_HeadShot_DecTime;
            set => WriteParamField(ref _Damage_HeadShot_DecTime, value);
        }
        private float _Damage_HeadShot_DecTime;

        [ParamField(0x68, ParamType.F32)]
        public float Guard_S_DecTime
        {
            get => _Guard_S_DecTime;
            set => WriteParamField(ref _Guard_S_DecTime, value);
        }
        private float _Guard_S_DecTime;

        [ParamField(0x6C, ParamType.F32)]
        public float Guard_L_DecTime
        {
            get => _Guard_L_DecTime;
            set => WriteParamField(ref _Guard_L_DecTime, value);
        }
        private float _Guard_L_DecTime;

        [ParamField(0x70, ParamType.F32)]
        public float Guard_LL_DecTime
        {
            get => _Guard_LL_DecTime;
            set => WriteParamField(ref _Guard_LL_DecTime, value);
        }
        private float _Guard_LL_DecTime;

        [ParamField(0x74, ParamType.F32)]
        public float GuardBrake_DecTime
        {
            get => _GuardBrake_DecTime;
            set => WriteParamField(ref _GuardBrake_DecTime, value);
        }
        private float _GuardBrake_DecTime;

        [ParamField(0x78, ParamType.Dummy8, 8)]
        public byte[] Pad
        {
            get => _Pad;
            set => WriteParamField(ref _Pad, value);
        }
        private byte[] _Pad = null!;

    }
}
