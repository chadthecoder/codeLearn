    segment .data
    
a db "Hello World", 0
    
    segment .text
    global _start

end_if:
    mov eax, 60
    mov edi, 1
   syscall
            
_start:

    mov rax, 6
    
;    if ( rax > 5 ) jump to end_if
     cmp     rax, 5      ; subtracts rax-5 without saving
     jg     end_if      ; jump if greater than


    mov eax, 60
    mov edi, 5
    syscall
    
;end_if:                     ; name the label what you want
