.data
set_event_flag_ptr qword 0  ;ptr to buffer

.code

set_event_flag_detour proc
    push rbx
    mov rbx, set_event_flag_ptr

    mov [rbx   ],rcx
    mov [rbx+8 ],edx
    mov [rbx+12],r8d
    pop rbx
set_event_flag_detour endp
    ;mov [rsp+0x8],rbx




end