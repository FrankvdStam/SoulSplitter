use ilhook::x64::Registers;

mod migt_tests;

pub fn empty_registers() -> Registers
{
    Registers
    {
        xmm0: 0,
        xmm1: 0,
        xmm2: 0,
        xmm3: 0,
        r15: 0,
        r14: 0,
        r13: 0,
        r12: 0,
        r11: 0,
        r10: 0,
        r9: 0,
        r8: 0,
        rbp: 0,
        rdi: 0,
        rsi: 0,
        rdx: 0,
        rcx: 0,
        rbx: 0,
        rsp: 0,
        rflags: 0,
        _no_use: 0,
        rax: 0,
    }
}