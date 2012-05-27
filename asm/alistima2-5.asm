lxi h,0100h;
mvi b,00h; döngü sayımız

dongu: mvi M,0;
       inx h;
       dcr b;
       jnz dongu

hlt
