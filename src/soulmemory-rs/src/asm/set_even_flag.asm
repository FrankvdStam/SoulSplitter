extrn log_event_flag : proc

.code

set_event_flag_detour_asm proc
    push rdx                    ; save registers
    push rdx
    push r8
    call log_event_flag         ; log values from rust
    pop r8                      ; restore registers
    pop rdx
    pop rdx
    mov [rsp+08],rbx            ; detour replaces this instruction
    nop                         ; replace with jmp back because detours lib doesn't properly do that
    nop
    nop
    nop
    nop
    nop
    nop
    nop
    nop
    ret
set_event_flag_detour_asm endp
    ;mov [rsp+0x8],rbx


end