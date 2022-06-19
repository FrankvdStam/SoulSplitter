.data
scale Real4 0.96  ;ptr to buffer
frac  Real4 0.0

public update_igt_detour
update_igt_detour proc
    mulss     xmm1,  scale              ; multiply frame delta by scale

    movups    xmm14, xmm1               ; frame time to double
    cvtss2sd  xmm14, xmm14              ;
    cvttsd2si rax,   xmm14              ; cast scaled frametime to int
    cvtsi2sd  xmm15, rax                ; cast int frametime to double
    subsd     xmm14, xmm15              ; subtract int frametime from double frametime -> only the fracture remains

    movss     xmm15, frac               ; load previous fracture
    addsd     xmm15, xmm14              ; add fractures
    movss     frac, xmm15               ; store new fracture

    cvttsd2si rax,   xmm15              ; cast fracture to int
    test      rax,   rax                ; if fracture is 1 or bigger
    jz        frac_smaller_than_1

    nop                                 ;
    cvtsi2sd  xmm14, rax                ; convert fracture back to double (will always be 1)
    subsd     xmm15, xmm14              ; remove from fracture
    movss     frac, xmm15               ; store remainder of fracture
    cvtsd2ss  xmm14, xmm14              ; convert fracture from double to single
    addss     xmm1, xmm14               ; add fracture to frame delta

frac_smaller_than_1:
    xorps     xmm14, xmm14              ; zero xmm14
    xorps     xmm15, xmm15              ; zero xmm15
    cvttss2si rax,xmm1                  ; cast unscaled frame delta to int in rax (eax will be added to igt)

    jmp jmp_placeholder                 ; This label is just a placeholder, the return address will have to be calculated and written here at runtime
jmp_placeholder:
    ret                                 ; Returing so that disassemblers can read this code

update_igt_detour endp




end