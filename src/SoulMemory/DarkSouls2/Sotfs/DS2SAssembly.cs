using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoulMemory.DarkSouls2.Sotfs
{
    // Taken from DSR Gadget because TK code is better than anything I could write.
    // Parses output from https://defuse.ca/online-x86-assembler.htm
    // I like to keep the whole thing for quick reference to line numbers and so on
    static class DS2SAssembly
    {
        private static Regex asmLineRx = new Regex(@"^[\w\d]+:\s+((?:[\w\d][\w\d] ?)+)");

        private static byte[] LoadDefuseOutput(string lines)
        {
            List<byte> bytes = new List<byte>();
            foreach (string line in Regex.Split(lines, "[\r\n]+"))
            {
                Match match = asmLineRx.Match(line);
                string hexes = match.Groups[1].Value;
                foreach (Match hex in Regex.Matches(hexes, @"\S+"))
                    bytes.Add(Byte.Parse(hex.Value, System.Globalization.NumberStyles.AllowHexSpecifier));
            }
            return bytes.ToArray();
        }

        
        //TODO fix properties
        public static byte[] AddSouls           = new byte[0]; //LoadDefuseOutput(Properties.Resources.AddSouls);
        public static byte[] GetItem            = new byte[0]; //LoadDefuseOutput(Properties.Resources.GiveItemWithMenu);
        public static byte[] GetItemNoMenu      = new byte[0]; //LoadDefuseOutput(Properties.Resources.GiveItemWithoutMenu);
        public static byte[] SpeedFactorAccel   = new byte[0]; //LoadDefuseOutput(Properties.Resources.SpeedFactorAccel);
        public static byte[] OgSpeedFactorAccel = new byte[0]; //LoadDefuseOutput(Properties.Resources.OgSpeedFactorAccel);
        public static byte[] SpeedFactor        = new byte[0]; //LoadDefuseOutput(Properties.Resources.SpeedFactor);
        public static byte[] OgSpeedFactor      = new byte[0]; //LoadDefuseOutput(Properties.Resources.OgSpeedFactor);
        public static byte[] BonfireWarp        = LoadDefuseOutput(@"0:  48 81 ec 10 01 00 00    sub    rsp,0x110
7:  48 ba 00 00 00 00 ff    movabs rdx,0xffffffff00000000
e:  ff ff ff
11: 0f b7 12                movzx  edx,WORD PTR [rdx]
14: 48 8d 4c 24 50          lea    rcx,[rsp+0x50]
19: 41 b8 02 00 00 00       mov    r8d,0x2
1f: 49 be 00 00 00 00 ff    movabs r14,0xffffffff00000000
26: ff ff ff
29: 41 ff d6                call   r14
2c: 48 b9 00 00 00 00 ff    movabs rcx,0xffffffff00000000
33: ff ff ff
36: 48 89 c2                mov    rdx,rax
39: 49 be 00 00 00 00 ff    movabs r14,0xffffffff00000000
40: ff ff ff
43: 41 ff d6                call   r14
46: 48 81 c4 10 01 00 00    add    rsp,0x110
4d: c3                      ret ");

        public static byte[] ApplySpecialEffect = LoadDefuseOutput(@"0:  48 83 ec 38             sub    rsp,0x38
4:  48 ba 00 00 00 00 ff    movabs rdx,0xffffffff00000000
b:  ff ff ff
e:  48 b9 00 00 00 00 ff    movabs rcx,0xffffffff00000000
15: ff ff ff
18: 48 b8 00 00 00 00 ff    movabs rax,0xffffffff00000000
1f: ff ff ff
22: f3 0f 10 00             movss  xmm0,DWORD PTR [rax]
26: f3 0f 11 44 24 28       movss  DWORD PTR [rsp+0x28],xmm0
2c: 48 b8 00 00 00 00 ff    movabs rax,0xffffffff00000000
33: ff ff ff
36: ff d0                   call   rax
38: 48 83 c4 38             add    rsp,0x38
3c: c3                      ret ");
    }
}
