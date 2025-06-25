# PROPOSAL PROYEK AKHIR  
## PEMROGRAMAN BERORIENTASI OBJEK  

## Gravity Chess  

**The Lazy Jenius**  
**Muhammad Yusuf Qardhawi** (5053241026)  
**Fadhilla Dafa Karunia** (5053241003)  

---

**DEPARTEMEN TEKNIK INFORMATIKA**  
**INSTITUT TEKNOLOGI SEPULUH NOPEMBER**  
**2025**

---

## A. Latar Belakang Aplikasi  

Permainan catur adalah salah satu permainan papan yang sangat populer dan dikenal luas karena mengasah kemampuan berpikir strategis. Namun, seiring berkembangnya teknologi dan pola hiburan digital, banyak anak muda mulai kehilangan minat terhadap catur klasik karena dianggap monoton dan kurang inovasi.  

Permasalahan ini mendorong kami untuk membuat sebuah inovasi permainan catur dengan menambahkan unsur gravitasi, sehingga tiap bidak catur dapat jatuh ke posisi terbawah pada kolomnya setelah bergerak.  

Dengan demikian, **Gravity Chess** diharapkan dapat menarik kembali minat generasi muda terhadap permainan catur dengan sensasi strategi yang baru dan menantang.

---

## B. Deskripsi Aplikasi  

Sebagai seorang pemain, saya ingin memainkan permainan catur dengan aturan baru di mana setiap bidak yang digerakkan akan terpengaruh oleh gravitasi dan jatuh ke posisi paling bawah pada kolomnya, sehingga permainan menjadi lebih menantang dan tidak monoton seperti catur biasa.  

Saya ingin dapat bermain bersama teman (**Player vs Player**) serta menikmati tampilan papan dan bidak yang interaktif.

---

## C. Manfaat Aplikasi  

1. **Edukasi & Hiburan**: Gravity Chess dapat melatih kemampuan berpikir kritis, logika, serta kreativitas dalam merancang strategi baru yang berbeda dari catur biasa.  
2. **Inovasi Game Tradisional**: Menghidupkan kembali minat masyarakat terhadap catur dengan sentuhan inovasi modern.  
3. **Potensi Komersial**: Dengan keunikan aturan gravitasi, Gravity Chess berpotensi menjadi game viral di kalangan pecinta catur dan casual gamer, serta dapat dikembangkan menjadi aplikasi mobile atau web dan dipasarkan melalui platform digital.  

---

## D. Fitur-fitur Aplikasi  

- **Papan Catur Interaktif**: Ukuran 8x8 dengan tampilan digital.  
- **Bidak Catur Lengkap**: Pawn, Rook, Knight, Bishop, Queen, King, masing-masing dengan aturan gerak yang sudah dimodifikasi efek gravitasi.  
- **Gravity Mechanic**: Setelah melakukan langkah, bidak akan jatuh ke posisi terbawah di kolom tersebut.  
- **Player vs Player**: Dua pemain dapat bermain secara bergantian.  
- **Deteksi Check & Checkmate**: Sistem otomatis mendeteksi kondisi check dan checkmate sesuai aturan gravitasi.  
- **UI/UX Sederhana**: Desain antarmuka sederhana dan ramah pengguna.  

---

## E. Cakupan Aplikasi  

- Implementasi papan catur digital 8x8  
- Sistem bidak lengkap dengan perilaku dasar  
- Mekanisme gravitasi pada setiap langkah
- Tema papan dan bidak yang bisa dikustomisasi  

---

## F. Desain Kelas (Class Diagram)  

- **Piece** (abstract class): Atribut posisi, method abstrak `move()`  
- **Pawn, Rook, Knight, Bishop, Queen, King**: Turunan dari `Piece`, override method `move()`  
- **Board**: Menyimpan status papan, method cek validasi langkah dan gravitasi   
- **Game**: Mengatur alur dan logika permainan  

---

## G. Pembagian Kerja Tim  

- **Lead Programmer**: Bertanggung jawab pada arsitektur kode dan implementasi fitur utama (Gravity Mechanic, Board, Piece)  
- **UI/UX Designer**: Mendesain dan mengimplementasikan tampilan antarmuka pengguna  
- **Game Tester**: Menguji seluruh fitur, mencari bug, dan memberikan feedback pada pengembangan  
- **Dokumentasi**: Membuat dokumentasi penggunaan dan pengembangan aplikasi  

---

## H. Kompetisi yang akan Diikuti  

- **Nama**: GEMASTIK 2025  
- **Tanggal**: -  
- **Penyelenggara**: -  
- **Tema**: Game edukasi dan inovasi digital  
- **Teknologi**: C#, platform Windows  
- **Kesesuaian**: Aplikasi memadukan konsep edukasi OOP dan hiburan interaktif, sesuai tema  
