# C# Basit Derleyici
Kendi sözdizimini kullanarak ekrana yazdırma ve dört işlem yapabilen mini, basit bir derleyici uygulaması.

Kod bloğu `basla;` ile baslayip `bitir;` ile bitirilmelidir.
`yazdir<` komutu, '<' ile ';' arasına yazılan metni konsola yazdırır. Her satır ';' ile bitmelidir.
`topla:` , `cikar:` ve ` carp:` komutları, ':' ile ayrılan sayılara toplama, çıkarma, çarpma işlemlerini yapar. Örn: `topla:5:2:3;`
`bol:` komutu, ':' ile ayrılan iki sayıdan ilkini ikinciye böler. Örn: `bol:10:2;`

#### Tasarlanan Dilde Örnek Kod
    basla;
    yazdir<Merhaba;
    yazdir<50+3 sonucu:;
    topla:50:3;
    yazdir<10-20 sonucu:;
    cikar:10:20;
    yazdir<5x4x2 sonucu:;
    carp:5:4:2;
    yazdir<8/4 sonucu:;
    bol:8:4;
    bitir;

<img src="https://user-images.githubusercontent.com/34441864/129492408-a4953834-88d6-45e2-aa2a-c49fcc2265ab.gif" width=100%>

### Lisans
MIT License [LICENSE.md](https://github.com/koyuncuomer/c-sharp-basit-derleyici-2018/blob/8bc3dc2bfa972f57396551a15a33b3a969c08e6e/LICENSE "LICENSE.md")
