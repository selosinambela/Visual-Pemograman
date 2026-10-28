[README.md](https://github.com/user-attachments/files/34093963/README.md)
# Panduan Ujian Praktik Pemrograman Visual (VB.NET Windows Forms)

Mata kuliah Pemrograman Visual (TIF 3 031) · Visual Basic .NET · Windows Forms · .NET 10 · `Option Strict On`

Dokumen ini dibuat supaya kamu bisa mengerjakan **soal praktik yang mirip** Tugas Pertemuan 7 dan 8 walaupun kasusnya diganti (buku jadi barang, pegawai, pasien, dan seterusnya). Isinya: konsep inti, resep kerja dari nol, blok kode siap pakai, solusi lengkap kedua tugas, variasi soal yang mungkin muncul, daftar error beserta obatnya, dan checklist pengumpulan.

## Label sumber (baca ini dulu)

| Label | Artinya |
|---|---|
| **[REPO]** | Diambil atau diturunkan langsung dari `praktik.md` dan `tugas.md` Pertemuan 7 dan 8 di repo `shatahaq/pemograman-visual`. |
| **[UMUM]** | Pengetahuan umum VB.NET / Visual Studio. Tidak tertulis di repo, tetapi hanya memakai konsep dasar. |
| **[VARIASI]** | Tebakan variasi soal berdasarkan pola tugas. Tidak dijamin keluar, tetapi masuk akal. |

**Batasan yang jujur:** halaman `pertemuan-07/praktik.md`, `pertemuan-07/tugas.md`, `pertemuan-08/praktik.md`, dan `pertemuan-08/tugas.md` sudah saya baca penuh. Folder `Pertemuan2-Komponen-Visual` dan `Tugas` di repo tidak bisa saya buka (GitHub memblokir akses otomatis), jadi konsep Pertemuan 1 sampai 6 di Bagian 1 saya tulis dari pengetahuan umum VB.NET. Cocokkan dengan catatan kuliahmu, dan buka dua folder itu sendiri sebelum ujian. Gambar contoh di tugas juga tidak ikut terbaca.

**Aturan main ujian yang kemungkinan sama dengan tugas:** `Option Strict On`, hanya materi Pertemuan 1 sampai 8, tanpa database, semua kontrol dibuat di Designer (kontrol buatan kode tidak dinilai), dan setiap Sub/Function diberi komentar. Karena itu, hindari fitur di luar materi (LINQ, lambda, dan sejenisnya) walaupun lebih singkat.

---

## Daftar Isi

- [Bagian 0: Cara Memakai README Ini Saat Ujian](#bagian-0-cara-memakai-readme-ini-saat-ujian)
- [Bagian 1: Inti dan Konsep Dasar Vispro](#bagian-1-inti-dan-konsep-dasar-vispro)
- [Bagian 2: Resep Universal Membuat Aplikasi dari Nol](#bagian-2-resep-universal-membuat-aplikasi-dari-nol)
- [Bagian 3: Pertemuan 7, Validasi dan Error Handling](#bagian-3-pertemuan-7-validasi-dan-error-handling)
- [Bagian 4: Pertemuan 8, DataGridView, Array dan Koleksi Data](#bagian-4-pertemuan-8-datagridview-array-dan-koleksi-data)
- [Bagian 5: Variasi Soal yang Mungkin Keluar](#bagian-5-variasi-soal-yang-mungkin-keluar)
- [Bagian 6: Mengganti Kasus (Adaptasi) dan Soal Latihan](#bagian-6-mengganti-kasus-adaptasi-dan-soal-latihan)
- [Bagian 7: Error Umum dan Obatnya](#bagian-7-error-umum-dan-obatnya)
- [Bagian 8: Trik Visual Studio dan Hacks](#bagian-8-trik-visual-studio-dan-hacks)
- [Bagian 9: Checklist Akhir, Rubrik, dan Pengumpulan](#bagian-9-checklist-akhir-rubrik-dan-pengumpulan)
- [Penutup: 12 Kalimat yang Wajib Diingat](#penutup-12-kalimat-yang-wajib-diingat)

---

## Bagian 0: Cara Memakai README Ini Saat Ujian

### Alur 8 langkah begitu soal dibagikan

1. **Baca soal dua kali.** Garis bawahi angka dan batas: "1 sampai 14", "minimal 3 karakter", "minimal 10 buku". Di situlah nilai hilang.
2. **Salin tabel "Kontrol" dari soal** ke catatan. Itu daftar nama kontrol yang harus persis sama.
3. **Buat proyek**: Windows Forms App (Visual Basic, bukan ".NET Framework"), .NET 10, `Option Strict = On`, rename `Form1` jadi nama form yang diminta, cek Startup form.
4. **Designer dulu, kode belakangan.** Buat semua kontrol dan ganti `(Name)` sebelum double-click. Atur `MaxLength`, `DropDownStyle`, `Items`, `CausesValidation`, properti grid.
5. **Salin Module validasi** (Bagian 3.2) ke proyek.
6. **Data dan binding** kalau ada grid (Bagian 4).
7. **Urutan kode:** `ValidasiInput` → tombol utama → `BersihkanForm` → fitur lain (filter, ekspor, ringkasan).
8. **Uji setiap kasus** (tabel uji di tiap solusi), screenshot, tambah komentar, bersihkan `bin`/`obj`, zip.

### Pembagian waktu yang disarankan (proporsi, sesuaikan durasi ujian)

| Tahap | Porsi |
|---|---|
| Baca soal + proyek + Designer | sekitar 20% |
| Fitur wajib (kode) | sekitar 45% |
| Uji + screenshot | sekitar 15% |
| Komentar + zip + cek ulang | sekitar 10% |
| Tantangan tambahan | sisa waktu, **hanya setelah semua fitur wajib beres** |

### Indeks cepat (tekan Ctrl+F)

| Kalau soal minta... | Lihat |
|---|---|
| validasi isian, ikon merah ErrorProvider | 3.3, 3.4 |
| angka bulat atau desimal, dilarang `Val`/`CInt` | 3.1, 3.3 |
| kode berformat (misal `BK0012`, huruf kecil tetap diterima) | 3.2, 6.3 |
| cegah data ganda | 3.3 (List), 4.10 (loop DataRow) |
| ekspor CSV, file sedang dipakai Excel | 3.7 |
| tampilkan data di tabel | 4.1 sampai 4.4 |
| pencarian dan filter | 4.6 |
| dua syarat sekaligus (teks dan kategori) | 4.6 |
| tanda kutip bikin program error | 4.6 |
| jumlah, total, rata-rata dari baris yang tampil | 4.8, 5.3 |
| urutkan | 4.9 |
| hapus atau edit data | 5.1, 5.2 |
| kasusnya diganti (bukan buku) | Bagian 6 |
| ada garis merah atau error | Bagian 7 |

---

## Bagian 1: Inti dan Konsep Dasar Vispro

### 1.1 Apa itu pemrograman visual **[UMUM]**

Kamu **menggambar antarmuka** (tombol, kotak teks, tabel) di Designer, lalu **menulis kode** hanya untuk bereaksi pada kejadian pengguna. Urutan kerja: rancang tampilan, beri nama kontrol, baru tulis kode.

### 1.2 Event-driven: program menunggu kejadian **[UMUM]**

Program tidak berjalan dari atas ke bawah. Ia menunggu **event** (klik, ketik, form terbuka), lalu menjalankan Sub yang disambungkan ke event itu.

```vb
Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
    ' kode ini jalan setiap btnSimpan diklik
End Sub
```

- `btnSimpan_Click` hanya nama. Yang menyambungkan Sub ke event adalah **`Handles btnSimpan.Click`**.
- Kalau nama kontrol diganti setelah double-click, nama Sub tetap lama dan bisa membingungkan. Karena itu **ganti `(Name)` sebelum double-click**. **[REPO]**

Tiga istilah yang selalu dipakai:

| Istilah | Contoh | Artinya |
|---|---|---|
| Property | `txtNama.Text`, `txtNim.MaxLength` | data/ciri sebuah kontrol (dibaca atau diisi) |
| Method | `txtNama.Clear()`, `txtNim.Focus()` | perintah yang dijalankan kontrol |
| Event | `Click`, `TextChanged`, `Validating`, `Load` | kejadian yang bisa kamu tangani |

### 1.3 Struktur proyek **[REPO]**

```
Proyek
├─ FrmUtama.vb          menu pembuka; membuka form lain lewat ShowDialog
├─ FrmXxx.vb            kode form (yang kamu tulis)
├─ FrmXxx.Designer.vb   dibuat otomatis oleh Designer, JANGAN diedit
├─ ModValidasi.vb       Module: fungsi bantu yang bisa dipakai form mana pun
└─ Mahasiswa.vb         Class: cetakan satu data (satu baris)
```

| | Module | Class |
|---|---|---|
| Fungsinya | kumpulan Function/Sub bersama | cetakan objek (data + perilaku) |
| Dipakai dengan | dipanggil langsung: `Kosong(txtNama.Text)` | dibuat dulu: `New Mahasiswa(...)` |
| Aturan | semua fungsi **wajib** di dalam `Public Module ... End Module` | semua Sub form **wajib** di dalam `Public Class ... End Class` |

Membuka form lain **[REPO]**:

```vb
Dim frm As New FrmPendaftaran()
frm.ShowDialog()      ' modal: form di belakangnya tidak bisa diklik sampai ini ditutup
```

### 1.4 Naming convention **[REPO]**

| Awalan | Jenis | Contoh |
|---|---|---|
| `lbl` | Label | `lblJudul`, `lblJumlah` |
| `txt` | TextBox | `txtNim` |
| `btn` | Button | `btnSimpan` |
| `cbo` | ComboBox | `cboJurusan` |
| `lst` | ListBox | `lstMahasiswa` |
| `dgv` | DataGridView | `dgvBuku` |
| `bs` | BindingSource | `bsBuku` |
| `err` | ErrorProvider | `errInput` |
| `chk` | CheckBox | `chkStokHabis` |
| `Frm` | Form | `FrmUtama` |
| `Mod` | Module | `ModValidasi` |
| `rdo`, `dtp`, `nud`, `grp` **[UMUM]** | RadioButton, DateTimePicker, NumericUpDown, GroupBox | `rdoLaki`, `dtpTanggal` |

Setiap TextBox dan ComboBox punya Label keterangan sendiri berawalan `lbl` (misal `lblKodeBuku`, `lblCari`). Dilarang ada nama bawaan seperti `Label1` atau `Button1`.

Gaya penamaan lain: variabel `camelCase` (`daftarNim`, `tabelBuku`), Sub/Function `PascalCase` (`ValidasiInput`, `BersihkanForm`), event handler `namaKontrol_Event`.

### 1.5 Option Strict On dan tipe data

`Option Strict On` melarang konversi tipe yang berisiko terjadi diam-diam. Hasilnya: kamu **dipaksa** menulis konversi dengan benar. **[REPO]**

| Salah (error di Option Strict) | Benar |
|---|---|
| `Dim n As Integer = txtUsia.Text` | `Integer.TryParse(txtUsia.Text, n)` atau `Integer.Parse(txtUsia.Text)` |
| `lblHasil.Text = angka` | `lblHasil.Text = angka.ToString()` |
| `Dim h As Integer = 7 / 2` (hasil `/` itu Double) | `7 \ 2` (pembagian bulat) atau `CInt(...)` |
| `Dim s As String = baris("Judul")` (isinya Object) | `baris("Judul").ToString()` |
| memanggil anggota yang tidak ada pada `Object` | ubah dulu ke tipe yang benar (`CInt`, `CStr`, `.ToString()`) |

Tipe data yang dipakai di repo:

| Tipe | Dipakai untuk | Catatan |
|---|---|---|
| `String` | nama, NIM, kode | NIM/kode dibuat String agar angka 0 di depan tidak hilang |
| `Integer` | tahun, stok, angkatan | bilangan bulat |
| `Decimal` | IPK, uang | literal bertanda `D`: `3.45D` |
| `Boolean` | `valid`, hasil `TryParse` | `True`/`False` |
| `Date` | tanggal | `Date.Today`, `Date.Today.Year` |
| `Char` | satu karakter | literal bertanda `c`: `"0"c` |

### 1.6 Kontrol yang sering dipakai dan anggotanya

| Kontrol | Yang paling sering dipakai |
|---|---|
| TextBox | `.Text`, `.MaxLength`, `.Clear()`, `.Focus()`, event `TextChanged`, `Validating` **[REPO]** |
| Label | `.Text`, `.AutoSize` (kalau `False`, **wajib** atur `Size` manual supaya teks tidak terpotong) **[REPO]** |
| Button | event `Click`, `.CausesValidation` **[REPO]** |
| ComboBox | `.Items`, `.SelectedIndex` (`-1` = belum memilih), `.Text`, `.DropDownStyle = DropDownList` **[REPO]** |
| ListBox | `.Items.Add(...)`, `.Items.Count`, `.Items.Clear()`, `.HorizontalScrollbar` **[REPO]**; `.SelectedIndex`, `.Items.RemoveAt(i)` **[UMUM]** |
| CheckBox | `.Checked`, event `CheckedChanged` **[REPO]** |
| DataGridView | `.DataSource`, `.Rows`, `.Columns("Nama")`, `.Rows.Count`, `.ReadOnly`, `.SelectionMode`, `.AutoSizeColumnsMode` **[REPO]** |
| BindingSource | `.DataSource`, `.Filter`, `.RemoveFilter()`, `.Sort`, `.Count`, `.Add(...)` **[REPO]**; `.Current`, `.RemoveCurrent()` **[UMUM]** |
| ErrorProvider | `.SetError(kontrol, "pesan")`, `.SetError(kontrol, "")`, `.Clear()` **[REPO]** |
| Form | `.ShowDialog()`, `AcceptButton`, `StartPosition`, `FormBorderStyle`, `MaximizeBox`, event `Load` **[REPO]** |
| RadioButton, DateTimePicker, NumericUpDown **[UMUM]** | `.Checked`; `.Value` (tanggal); `.Value` (angka) |

Properti form yang dipakai di semua praktik **[REPO]**: `Text`, `ClientSize`, `StartPosition = CenterScreen`, `FormBorderStyle = FixedSingle`, `MaximizeBox = False`.

### 1.7 Cheat sheet sintaks VB **[UMUM]**

```vb
' ---- Variabel ----
Dim nama As String = "Andi"
Dim stok As Integer = 5
Dim ipk As Decimal = 3.45D
Dim aktif As Boolean = True
Const BatasMaks As Integer = 14

' ---- Operator ----
'  =  sama dengan / isi nilai     <>  tidak sama      &  gabung teks
'  \  bagi bulat    Mod  sisa bagi    AndAlso / OrElse  (dan / atau, berhenti begitu hasil pasti)

' ---- If ----
If stok = 0 Then
    lblStatus.Text = "Habis"
ElseIf stok < 5 Then
    lblStatus.Text = "Menipis"
Else
    lblStatus.Text = "Aman"
End If

' ---- Select Case ----
Select Case cboUrut.SelectedIndex
    Case 1
        bsBuku.Sort = "Judul ASC"
    Case 2, 3
        bsBuku.Sort = "Tahun DESC"
    Case Else
        bsBuku.Sort = ""
End Select

' ---- Perulangan ----
For i As Integer = 0 To 9            ' 0..9
Next
For Each baris As DataRow In tabelBuku.Rows
Next
Do While kondisi
Loop
' keluar dari loop lebih awal: Exit For / Exit Do     keluar dari Sub: Return

' ---- Function dan Sub ----
Private Function Kuadrat(x As Integer) As Integer
    Return x * x
End Function

' ---- Array dan List ----
Dim a(4) As Integer                              ' 5 elemen, indeks 0..4
Dim b() As String = {"Fiksi", "Nonfiksi"}
Dim m(,) As String = {{"1", "A"}, {"2", "B"}}    ' 2 dimensi: m(baris, kolom)
Dim daftar As New List(Of String)
daftar.Add("BK0001") : daftar.Contains("BK0001") : daftar.Count : daftar.Remove("BK0001") : daftar.Clear()

' ---- Teks ----
teks.Trim()  teks.ToUpper()  teks.ToLower()  teks.Length  teks.Contains("an")
teks.StartsWith("BK")  teks.Substring(2)  teks.Replace(" | ", ";")
teks.Split("|"c)(0)                              ' bagian pertama sebelum "|"
ipk.ToString("0.00")                             ' paksa 2 desimal
Date.Today.AddDays(7).ToString("dd/MM/yyyy")     ' tanggal 7 hari lagi

' ---- Pesan ----
MessageBox.Show("Isi pesan", "Judul", MessageBoxButtons.OK, MessageBoxIcon.Warning)
If MessageBox.Show("Yakin?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
End If
```

### 1.8 Alur data yang dipakai di Pertemuan 8 **[REPO]**

```
 data di memori                perantara                  tampilan
[ List(Of T) / DataTable ] --> [ BindingSource ] --> [ DataGridView ]
                                 .Filter  .Sort
```

Kenapa memakai BindingSource: grid otomatis ikut berubah saat data berubah, dan filter/urut dipasang di BindingSource, bukan di grid.

### 1.9 Peta materi repo

| Pertemuan | Tema | Isi yang dipakai di ujian |
|---|---|---|
| 2 | Komponen visual | kontrol dasar, properti, event (folder `Pertemuan2-Komponen-Visual`, tidak terbaca oleh saya) |
| 7 | Validasi, error handling, naming convention | `TryParse`, `Try...Catch...Finally`, `ErrorProvider`, `Validating`, Module validasi, ekspor CSV |
| 8 | DataGridView, Array, koleksi data | Array 2D, `List(Of T)`, `DataTable`, `BindingSource`, filter, kolom rapi, ringkasan |

---
## Bagian 2: Resep Universal Membuat Aplikasi dari Nol

### 2.1 Langkah proyek **[REPO]**

1. Visual Studio → **Create a new project** → **Windows Forms App** dengan bahasa **Visual Basic**. Pilih yang **bukan** ".NET Framework" (letaknya bersebelahan, mudah salah klik).
2. Beri nama proyek, framework **.NET 10**.
3. Klik kanan proyek → **Properties** → **Compile** → **Option strict = On**.
4. Rename `Form1.vb` ke nama form yang diminta (klik kanan → Rename). Kalau ditanya soal referensi, pilih **Yes**.
5. Properties → **Application** → pastikan **Startup form** berisi form tadi.
6. Tambah file lain: klik kanan proyek → **Add** → **Module** / **Class** / **Form (Windows Forms)**. Menyalin dari proyek lama: **Add** → **Existing Item**.

### 2.2 Delapan aturan emas

1. **Ganti `(Name)` dulu, baru double-click.**
2. **`Option Strict On`** ada di baris pertama setiap file kode (dan aktif di Project Properties).
3. Semua **Function di dalam Module**, semua **Sub form di antara `Public Class` dan `End Class`**. Salah letak jadi error "Statement is not valid in a namespace". **[REPO, kejadian nyata]**
4. Semua kontrol dan komponen (**termasuk `BindingSource` dan `ErrorProvider`**) dibuat di **Designer**, bukan lewat kode.
5. Setiap Sub dan Function diberi **komentar satu baris** di atasnya (masuk penilaian).
6. Urutan di `Load`: buat data → isi `DataSource` → atur kolom grid → pasang filter awal.
7. Validasi: setiap aturan adalah `If` yang **berdiri sendiri** (semua kesalahan tampil sekaligus), pesan lewat `ErrorProvider`, **bukan** `MessageBox`.
8. Setelah semua jalan: buka form di Designer, pastikan **tidak ada error**, lalu baru zip.

### 2.3 Kerangka kode form yang rapi

```vb
Option Strict On

Imports System.ComponentModel   ' hanya jika memakai event Validating
Imports System.IO               ' hanya jika membaca/menulis file

' Form untuk ... (satu kalimat tujuan form)
Public Class FrmContoh

    ' ---- 1. Data di tingkat class ----
    Private ReadOnly daftarKode As New List(Of String)

    ' ---- 2. Event Load: siapkan data, binding, tampilan awal ----
    Private Sub FrmContoh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    ' ---- 3. Validasi ----
    Private Function ValidasiInput() As Boolean
        Return True
    End Function

    ' ---- 4. Tombol utama (Tambah/Simpan/Pinjam) ----
    ' ---- 5. BersihkanForm + tombol Bersihkan ----
    ' ---- 6. Fitur lain: filter, ekspor, ringkasan ----

End Class
```

---

## Bagian 3: Pertemuan 7, Validasi dan Error Handling

### 3.1 Konversi teks ke angka: lima cara dan perbedaannya **[REPO]**

`TextBox` selalu berisi **String**. Pengguna boleh mengetik apa saja, termasuk `abc`.

| Cara | Input `25` | Input `abc` | Input `12abc` | Input kosong | Catatan |
|---|---|---|---|---|---|
| `CInt(txt.Text)` tanpa Try | 25 | **crash** `InvalidCastException` | crash | crash | sengaja dibuat salah di praktik |
| `Val(txt.Text)` | 25 | 0 (diam-diam) | 12 (diam-diam) | 0 | tidak pernah error, tetapi menyesatkan; `3,5` terbaca 3 karena hanya titik yang dikenal |
| `Integer.TryParse(txt.Text, n)` | True, n=25 | **False** | False | False | **cara utama untuk validasi**, tanpa exception |
| `Try Integer.Parse(...) Catch` | 25 | `FormatException` | `FormatException` | `FormatException` | untuk error yang tidak bisa dicegah |
| Catch bertingkat | | `FormatException` | | | `99999999999` → `OverflowException`; `1000 \ 0` → `DivideByZeroException` |

**Kapan pakai apa:**
- **Validasi input pengguna: `TryParse`.** Kalau soal berkata "dibaca dengan `Integer.TryParse`, bukan `Val` atau `CInt`", wajib begitu.
- **`Try...Catch`:** untuk hal di luar kendali, misalnya file sedang dipakai program lain.
- Setelah validasi lolos, boleh memakai `Integer.Parse` tanpa `Try` karena nilainya pasti valid.

### 3.2 `ModValidasi.vb` (salin utuh) **[REPO]**

Fungsi harus berada **di dalam** `Public Module ... End Module`.

```vb
Option Strict On

Imports System.Globalization

' Kumpulan fungsi validasi yang bisa dipakai ulang oleh form mana pun
Public Module ModValidasi

    ' True jika teks kosong atau hanya berisi spasi
    Public Function Kosong(teks As String) As Boolean
        Return teks.Trim() = ""
    End Function

    ' True jika panjang teks tepat sesuai dan semua karakternya digit 0-9
    Public Function SemuaDigit(teks As String, panjang As Integer) As Boolean
        If teks.Length <> panjang Then Return False
        For Each karakter As Char In teks
            If karakter < "0"c OrElse karakter > "9"c Then Return False
        Next
        Return True
    End Function

    ' Koma dan titik sama-sama diterima, hasil tidak bergantung bahasa Windows
    Public Function CobaDesimal(teks As String, ByRef hasil As Decimal) As Boolean
        Dim teksTitik As String = teks.Trim().Replace(",", ".")
        Return Decimal.TryParse(teksTitik, NumberStyles.AllowDecimalPoint,
                                CultureInfo.InvariantCulture, hasil)
    End Function

    ' True jika kode berformat "BK" diikuti 4 digit (huruf besar/kecil sama saja)
    Public Function KodeBukuValid(kode As String) As Boolean
        Dim k As String = kode.Trim().ToUpper()
        If k.Length <> 6 Then Return False        ' cek panjang dulu agar Substring aman
        If Not k.StartsWith("BK") Then Return False
        Return SemuaDigit(k.Substring(2), 4)      ' "BK0012" -> "0012"
    End Function

End Module
```

Cara membaca:
- `Kosong`: `Trim()` membuang spasi, jadi isian berisi spasi saja tetap dianggap kosong.
- `SemuaDigit`: cek panjang dulu, lalu cek tiap karakter. `OrElse` berhenti begitu syarat pertama terpenuhi.
- `CobaDesimal`: `3,45` dan `3.45` sama-sama diterima. `ByRef` artinya hasil dikembalikan lewat parameter (mirip `TryParse`).
- `KodeBukuValid`: panjang dicek **sebelum** `Substring` supaya tidak error.

### 3.3 Pola `ValidasiInput` (paling sering diujikan) **[REPO]**

```vb
' Memeriksa semua isian sekaligus. True jika semuanya valid.
Private Function ValidasiInput() As Boolean
    errInput.Clear()                              ' 1. hapus ikon merah lama
    Dim valid As Boolean = True                   ' 2. anggap benar dulu

    If Kosong(txtNama.Text) Then                  ' 3. tiap aturan = satu If SENDIRI
        errInput.SetError(txtNama, "Nama wajib diisi.")
        valid = False
    End If

    ' ... aturan lain ...

    Return valid                                  ' 4. kembalikan hasil
End Function
```

**Rumus aturan → kode** (tinggal tempel dan ganti nama kontrol):

| Aturan soal | Kondisi "salah" di dalam `If` |
|---|---|
| wajib diisi | `Kosong(txtJudul.Text)` |
| minimal N karakter (tanpa spasi tepi) | `txtNama.Text.Trim().Length < 3` |
| tepat N digit angka | `Not SemuaDigit(txtNim.Text, 9)` |
| "BK" + 4 digit | `Not KodeBukuValid(txtKodeBuku.Text)` |
| bilangan bulat a sampai b | `Not Integer.TryParse(txt.Text, x) OrElse x < a OrElse x > b` |
| tahun 1900 sampai tahun ini | `Not Integer.TryParse(txtTahun.Text, t) OrElse t < 1900 OrElse t > Date.Today.Year` |
| bilangan bulat 0 atau lebih | `Not Integer.TryParse(txtStok.Text, s) OrElse s < 0` |
| desimal 0 sampai 4 | `Not CobaDesimal(txtIpk.Text, ipk) OrElse ipk < 0D OrElse ipk > 4D` |
| ComboBox wajib dipilih | `cboJurusan.SelectedIndex = -1` |
| tidak boleh ganda (List) | `daftarKode.Contains(kode)` |
| tidak boleh ganda (DataTable) | fungsi loop `KodeSudahAda(kode)` (lihat 4.10) |

Catatan penting:
- **Kenapa `OrElse` dan urutannya:** `Not TryParse(...) OrElse x < a`. Kalau konversi gagal, bagian setelah `OrElse` tidak dievaluasi, jadi batas rentang hanya diperiksa kalau konversinya berhasil.
- **Format dulu, duplikat kemudian** (`If ... ElseIf ...`). Duplikat hanya dicek kalau format sudah benar:

```vb
Dim kode As String = txtKodeBuku.Text.Trim().ToUpper()   ' huruf kecil tetap diterima, simpan huruf besar
If Not KodeBukuValid(kode) Then
    errPinjam.SetError(txtKodeBuku, "Kode harus 'BK' + 4 digit, contoh BK0012.")
    valid = False
ElseIf daftarKodeDipinjam.Contains(kode) Then
    errPinjam.SetError(txtKodeBuku, "Buku ini sedang dipinjam.")   ' pesan persis dari soal
    valid = False
End If
```

- **Pesan persis dari soal**: kalau soal menyebut teks pesan (misal "Buku ini sedang dipinjam."), tulis **persis begitu**.

### 3.4 ErrorProvider **[REPO]**

| Perintah | Efek |
|---|---|
| `errInput.SetError(txtNim, "pesan")` | ikon merah muncul di samping `txtNim`; pesan tampil saat mouse diarahkan |
| `errInput.SetError(txtNim, "")` | ikon `txtNim` dihapus |
| `errInput.Clear()` | semua ikon dihapus |

Ambil dari Toolbox grup **Components**, muncul di *component tray* di bawah form, lalu ganti `(Name)`-nya.

### 3.5 Validasi saat pindah kotak: event `Validating` **[REPO]**

Tidak dibuat dengan double-click kontrol. Pilih kontrol di Designer → Properties → ikon **petir (Events)** → double-click baris **Validating**.

```vb
' Memeriksa NIM saat fokus meninggalkan kotak
Private Sub txtNim_Validating(sender As Object, e As CancelEventArgs) Handles txtNim.Validating
    If txtNim.Text = "" Then Return                 ' kosong dibiarkan, dicek saat Simpan
    If SemuaDigit(txtNim.Text, 9) Then
        errInput.SetError(txtNim, "")
    Else
        errInput.SetError(txtNim, "NIM harus 9 digit angka.")
    End If
End Sub
```

- Butuh `Imports System.ComponentModel` di atas file.
- **Jangan** memakai `e.Cancel = True`: itu mengunci kursor di kotak dan soal melarangnya.
- `CausesValidation = False` pada tombol Bersihkan/Ekspor supaya mengkliknya tidak memicu validasi (pengguna tetap bisa membersihkan form yang isiannya salah).
- Untuk kode buku, panggil `KodeBukuValid(txtKodeBuku.Text)` di sini dan di `ValidasiInput`: ini tantangan tambahan Tugas 7.

### 3.6 Try...Catch...Finally dan exception **[REPO]**

```vb
Try
    ' kode yang mungkin gagal
Catch ex As FormatException
    ' yang SPESIFIK ditulis dulu
Catch ex As OverflowException
Catch ex As Exception
    ' yang UMUM paling bawah (jaring pengaman)
Finally
    ' SELALU jalan, error atau tidak (misal menutup file)
End Try
```

- Kalau `Exception` ditaruh di atas, Catch di bawahnya **tidak akan pernah tercapai**.

| Exception | Pemicu | Sumber |
|---|---|---|
| `FormatException` | `Integer.Parse("abc")` | **[REPO]** |
| `OverflowException` | `Integer.Parse("99999999999")` | **[REPO]** |
| `DivideByZeroException` | `1000 \ 0` (pembagian bulat) | **[REPO]** |
| `InvalidCastException` | `CInt("abc")` | **[REPO]** |
| `IOException` | file CSV sedang dibuka di Excel | **[REPO]** |
| `UnauthorizedAccessException` | tidak punya izin menulis ke lokasi file | **[REPO, ada di Tugas 7]** |

### 3.7 Ekspor ke CSV (Try...Catch...Finally) **[REPO]**

Hal yang selalu diminta: pemisah `;`, baris pertama judul kolom, daftar kosong tidak membuat file, dua `Catch` dengan pesan yang menjelaskan **apa yang harus dilakukan pengguna**, `StreamWriter` ditutup di `Finally`.

```vb
' Bagian atas class
Private ReadOnly lokasiEkspor As String =
    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "peminjaman.csv")

' Menyimpan isi lstPeminjaman ke file CSV (pemisah titik koma)
Private Sub btnEkspor_Click(sender As Object, e As EventArgs) Handles btnEkspor.Click
    If lstPeminjaman.Items.Count = 0 Then                  ' daftar kosong: jangan buat file
        MessageBox.Show("Belum ada data peminjaman untuk diekspor.", "Ekspor Dibatalkan",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return
    End If

    Dim penulis As StreamWriter = Nothing                  ' dideklarasi DI LUAR Try agar Finally bisa akses
    Try
        penulis = New StreamWriter(lokasiEkspor)
        penulis.WriteLine("KodeBuku;Judul;Kategori;Peminjam;LamaPinjam;TanggalKembali")   ' baris judul
        For Each baris As Object In lstPeminjaman.Items
            penulis.WriteLine(baris.ToString().Replace(" | ", ";"))   ' " | " diganti ";"
        Next
        lblStatus.Text = "Data diekspor ke " & lokasiEkspor
    Catch ex As UnauthorizedAccessException
        MessageBox.Show("Program tidak punya izin menulis ke folder Documents. " &
                        "Pilih lokasi lain atau jalankan program dengan izin yang sesuai.",
                        "Ekspor Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    Catch ex As IOException
        MessageBox.Show("File peminjaman.csv sedang dipakai program lain (misalnya Excel). " &
                        "Tutup file itu, lalu klik Ekspor lagi." & vbCrLf & ex.Message,
                        "Ekspor Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    Finally
        If penulis IsNot Nothing Then penulis.Close()      ' selalu ditutup
    End Try
End Sub
```

Cara menguji `IOException`: ekspor sekali, **buka `peminjaman.csv` di Excel**, jangan ditutup, lalu klik Ekspor lagi → muncul MessageBox (screenshot ketiga di Tugas 7).

### 3.8 SOLUSI LENGKAP Tugas 7: Form Peminjaman Buku **[REPO + disusun dari spesifikasi]**

**Kontrol di Designer** (semua nama persis dari soal):

| Kontrol | (Name) | Pengaturan |
|---|---|---|
| Label | `lblJudulForm` | Text `Peminjaman Buku`, Segoe UI 14pt Bold |
| Label + TextBox | `lblKodeBuku` / `txtKodeBuku` | `MaxLength` 6 (opsional) |
| Label + TextBox | `lblJudul` / `txtJudul` | |
| Label + ComboBox | `lblKategori` / `cboKategori` | `DropDownStyle = DropDownList`; Items: Fiksi, Nonfiksi, Referensi, Majalah |
| Label + TextBox | `lblNamaPeminjam` / `txtNamaPeminjam` | |
| Label + TextBox | `lblLamaPinjam` / `txtLamaPinjam` | `MaxLength` 2 (opsional) |
| Button | `btnPinjam` | Text `Pinjam`; jadikan `AcceptButton` form (Enter = Pinjam) |
| Button | `btnBersihkan` | Text `Bersihkan`, **`CausesValidation = False`** |
| ListBox | `lstPeminjaman` | `HorizontalScrollbar = True`, `IntegralHeight = False` |
| Button | `btnEkspor` | Text `Ekspor ke CSV`, `CausesValidation = False` |
| Label | `lblStatus` | `AutoSize = False`, beri `Size` cukup lebar |
| ErrorProvider | `errPinjam` | dari Toolbox grup Components |

Form: `FixedSingle`, `MaximizeBox = False`, `StartPosition = CenterScreen`. Tambahkan `ModValidasi.vb` dari Bagian 3.2.

**Kode `FrmPeminjaman.vb`:**

```vb
Option Strict On

Imports System.IO

' Form untuk mencatat peminjaman buku
Public Class FrmPeminjaman

    ' Kode buku yang sedang dipinjam (mencegah pinjam ganda)
    Private ReadOnly daftarKodeDipinjam As New List(Of String)

    ' Lokasi file CSV di folder Documents
    Private ReadOnly lokasiEkspor As String =
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "peminjaman.csv")

    ' Memeriksa semua isian sekaligus. True jika semuanya valid.
    Private Function ValidasiInput() As Boolean
        errPinjam.Clear()
        Dim valid As Boolean = True
        Dim kode As String = txtKodeBuku.Text.Trim().ToUpper()

        If Not KodeBukuValid(kode) Then
            errPinjam.SetError(txtKodeBuku, "Kode harus 'BK' + 4 digit, contoh BK0012.")
            valid = False
        ElseIf daftarKodeDipinjam.Contains(kode) Then
            errPinjam.SetError(txtKodeBuku, "Buku ini sedang dipinjam.")
            valid = False
        End If

        If Kosong(txtJudul.Text) Then
            errPinjam.SetError(txtJudul, "Judul wajib diisi.")
            valid = False
        End If

        If cboKategori.SelectedIndex = -1 Then
            errPinjam.SetError(cboKategori, "Pilih salah satu kategori.")
            valid = False
        End If

        If txtNamaPeminjam.Text.Trim().Length < 3 Then
            errPinjam.SetError(txtNamaPeminjam, "Nama peminjam minimal 3 karakter.")
            valid = False
        End If

        Dim lama As Integer
        If Not Integer.TryParse(txtLamaPinjam.Text, lama) OrElse lama < 1 OrElse lama > 14 Then
            errPinjam.SetError(txtLamaPinjam, "Lama pinjam harus bilangan bulat 1 sampai 14 hari.")
            valid = False
        End If

        Return valid
    End Function

    ' Mencatat peminjaman jika semua isian valid
    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        If Not ValidasiInput() Then Return

        Dim kode As String = txtKodeBuku.Text.Trim().ToUpper()
        Dim lama As Integer = Integer.Parse(txtLamaPinjam.Text)        ' aman: sudah divalidasi
        Dim tglKembali As String = Date.Today.AddDays(lama).ToString("dd/MM/yyyy")

        lstPeminjaman.Items.Add(kode & " | " & txtJudul.Text.Trim() & " | " & cboKategori.Text & " | " &
                                txtNamaPeminjam.Text.Trim() & " | " & lama.ToString() & " hari | kembali " & tglKembali)
        daftarKodeDipinjam.Add(kode)
        lblStatus.Text = "Jumlah peminjaman: " & lstPeminjaman.Items.Count.ToString()
        BersihkanForm()
    End Sub

    ' Mengosongkan semua isian dan tanda error
    Private Sub BersihkanForm()
        txtKodeBuku.Clear()
        txtJudul.Clear()
        cboKategori.SelectedIndex = -1
        txtNamaPeminjam.Clear()
        txtLamaPinjam.Clear()
        errPinjam.Clear()
        txtKodeBuku.Focus()
    End Sub

    ' Tombol Bersihkan
    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        BersihkanForm()
    End Sub

    ' Menyimpan daftar peminjaman ke CSV (isi persis seperti Bagian 3.7)
    Private Sub btnEkspor_Click(sender As Object, e As EventArgs) Handles btnEkspor.Click
        If lstPeminjaman.Items.Count = 0 Then
            MessageBox.Show("Belum ada data peminjaman untuk diekspor.", "Ekspor Dibatalkan",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim penulis As StreamWriter = Nothing
        Try
            penulis = New StreamWriter(lokasiEkspor)
            penulis.WriteLine("KodeBuku;Judul;Kategori;Peminjam;LamaPinjam;TanggalKembali")
            For Each baris As Object In lstPeminjaman.Items
                penulis.WriteLine(baris.ToString().Replace(" | ", ";"))
            Next
            lblStatus.Text = "Data diekspor ke " & lokasiEkspor
        Catch ex As UnauthorizedAccessException
            MessageBox.Show("Program tidak punya izin menulis ke folder Documents. " &
                            "Pilih lokasi lain atau jalankan program dengan izin yang sesuai.",
                            "Ekspor Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As IOException
            MessageBox.Show("File peminjaman.csv sedang dipakai program lain (misalnya Excel). " &
                            "Tutup file itu, lalu klik Ekspor lagi." & vbCrLf & ex.Message,
                            "Ekspor Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            If penulis IsNot Nothing Then penulis.Close()
        End Try
    End Sub

End Class
```

**Tantangan tambahan Tugas 7** (nilai lebih), tambahkan `Imports System.ComponentModel` di atas file:

```vb
' Memeriksa format kode buku saat fokus pindah (tanpa e.Cancel)
Private Sub txtKodeBuku_Validating(sender As Object, e As CancelEventArgs) Handles txtKodeBuku.Validating
    If txtKodeBuku.Text.Trim() = "" Then Return
    If KodeBukuValid(txtKodeBuku.Text) Then
        errPinjam.SetError(txtKodeBuku, "")
    Else
        errPinjam.SetError(txtKodeBuku, "Kode harus 'BK' + 4 digit, contoh BK0012.")
    End If
End Sub
```

(`KodeBukuValid` sudah ada di Module, jadi tantangan kedua otomatis terpenuhi.)

**Tabel uji Tugas 7:**

| Uji | Hasil yang benar |
|---|---|
| Klik Pinjam tanpa isi apa pun | ikon merah di kode, judul, kategori, nama, lama pinjam (**screenshot 1**) |
| `bk0012`, judul, kategori, nama `Rina Lubis`, lama `7` → Pinjam | baris baru di list berawalan `BK0012` (huruf besar), berakhir `7 hari` lalu `kembali <tanggal>`; `lblStatus` "Jumlah peminjaman: 1"; form kosong |
| Pinjam tiga buku berbeda | tiga baris di list (**screenshot 2**) |
| Masukkan `BK0012` lagi | "Buku ini sedang dipinjam." |
| `BK12` atau `XX0012` | pesan format kode |
| nama `  Al ` (2 karakter setelah di-trim) | error nama |
| lama `0`, `15`, `abc`, kosong | error lama pinjam; `14` diterima |
| Bersihkan | isian dan ikon merah hilang |
| Ekspor saat daftar kosong | MessageBox, **tidak ada file** |
| Ekspor, buka CSV di Excel, ekspor lagi | MessageBox "Ekspor Gagal" (**screenshot 3**), program tetap jalan |

---
## Bagian 4: Pertemuan 8, DataGridView, Array dan Koleksi Data

### 4.1 Tiga cara menyimpan data dan kapan memakainya **[REPO]**

| | Array 2 dimensi | `List(Of Mahasiswa)` | `DataTable` |
|---|---|---|---|
| Isi | semua String, tanpa nama kolom | objek dari Class; tiap `Public Property` jadi satu kolom | kolom punya **nama dan tipe** (`Integer`, `Decimal`, ...) |
| Tampil di grid | diisi manual (`Rows.Add` + loop) | lewat `BindingSource` | lewat `BindingSource` |
| Tambah data | tidak praktis | `bs.Add(obj)` | `tabel.Rows.Add(...)` |
| `bs.Filter` | tidak ada | **tidak didukung** | **didukung** |
| Cara mencari | loop | **loop**, hasil ke list baru | `bs.Filter` |
| Diurutkan klik header kolom | tidak | tidak | ya (bisa juga `bs.Sort`) |

Aturan binding yang membuat grid terisi:

```vb
bsMahasiswa.DataSource = sumberData       ' data -> BindingSource
dgvMahasiswa.DataSource = bsMahasiswa     ' BindingSource -> grid
```

- **Jangan** mengisi `DataSource` di Designer. Isi lewat kode di `Load`.
- Setelah grid terikat ke `DataSource`, **dilarang** `dgvX.Rows.Add(...)`: akan error "Rows cannot be programmatically added to the DataGridView's rows collection when the control is data-bound". Tambahkan ke sumber datanya (atau lewat `bs.Add`).
- Kolom grid **dibuat otomatis** saat `DataSource` diisi. Jadi `AturKolom` harus dipanggil **sesudahnya**.

Pengaturan grid di **Designer** untuk semua grid di repo: `AllowUserToAddRows = False`, `AllowUserToDeleteRows = False`, `ReadOnly = True`, `SelectionMode = FullRowSelect`, `MultiSelect = False`, `AutoSizeColumnsMode = Fill` (kecuali bila soal minta diatur lewat kode).

> Jebakan: bila `AllowUserToAddRows = True`, `dgv.Rows.Count` ikut menghitung **baris kosong tambahan** di bawah, sehingga jumlah lebih satu. Itu alasan wajib `False`.

### 4.2 Array 2 dimensi ke DataGridView **[REPO]**

Di praktik ini grid **tidak** terikat `DataSource`, jadi kolom dibuat manual: smart tag grid → **Edit Columns** → **Add** per kolom (isi `(Name)` seperti `colNim` dan `HeaderText`).

```vb
' Dimensi pertama = baris (mahasiswa), dimensi kedua = kolom
Private ReadOnly dataMahasiswa(,) As String = {
    {"231712001", "Andi Pratama", "Teknik Informatika", "2023", "3.45"},
    {"231712002", "Sari Wulandari", "Sistem Informasi", "2023", "3.8"}
}

' Mengisi grid dari array (dikosongkan dulu supaya tidak dobel)
Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
    dgvMahasiswa.Rows.Clear()
    For i As Integer = 0 To dataMahasiswa.GetUpperBound(0)          ' tiap baris
        Dim indeksBaris As Integer = dgvMahasiswa.Rows.Add()
        For j As Integer = 0 To dataMahasiswa.GetUpperBound(1)      ' tiap kolom
            dgvMahasiswa.Rows(indeksBaris).Cells(j).Value = dataMahasiswa(i, j)
        Next
    Next
    lblJumlah.Text = "Jumlah data: " & dgvMahasiswa.Rows.Count.ToString()
End Sub

' Mengosongkan grid
Private Sub btnKosongkan_Click(sender As Object, e As EventArgs) Handles btnKosongkan.Click
    dgvMahasiswa.Rows.Clear()
    lblJumlah.Text = "Jumlah data: 0"
End Sub
```

`GetUpperBound(0)` = indeks baris terakhir, `GetUpperBound(1)` = indeks kolom terakhir.

### 4.3 Class + `List(Of T)` + BindingSource **[REPO]**

```vb
Option Strict On

' Satu objek Mahasiswa mewakili satu baris data. Grid membaca setiap Public Property sebagai kolom.
Public Class Mahasiswa
    Public Property Nim As String
    Public Property Nama As String
    Public Property Jurusan As String
    Public Property Angkatan As Integer
    Public Property Ipk As Decimal

    Public Sub New(nim As String, nama As String, jurusan As String, angkatan As Integer, ipk As Decimal)
        Me.Nim = nim
        Me.Nama = nama
        Me.Jurusan = jurusan
        Me.Angkatan = angkatan
        Me.Ipk = ipk
    End Sub
End Class
```

```vb
Private ReadOnly daftarMahasiswa As New List(Of Mahasiswa)

' Menyiapkan data awal lalu menghubungkannya ke grid
Private Sub FrmDariList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    daftarMahasiswa.Add(New Mahasiswa("231712001", "Andi Pratama", "Teknik Informatika", 2023, 3.45D))
    daftarMahasiswa.Add(New Mahasiswa("231712002", "Sari Wulandari", "Sistem Informasi", 2023, 3.8D))

    bsMahasiswa.DataSource = daftarMahasiswa        ' List -> BindingSource
    dgvMahasiswa.DataSource = bsMahasiswa           ' BindingSource -> DataGridView
    lblJumlah.Text = "Jumlah data: " & bsMahasiswa.Count.ToString()
End Sub

' Menambah mahasiswa jika isian valid
Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
    If Not ValidasiInput() Then Return
    Dim ipk As Decimal
    CobaDesimal(txtIpk.Text, ipk)
    Dim baru As New Mahasiswa(txtNim.Text, txtNama.Text.Trim(), cboJurusan.Text,
                              Integer.Parse(txtAngkatan.Text), ipk)
    bsMahasiswa.Add(baru)         ' lewat BindingSource, BUKAN daftarMahasiswa.Add, agar grid langsung diperbarui
    lblJumlah.Text = "Jumlah data: " & bsMahasiswa.Count.ToString()
    BersihkanInput()
End Sub
```

Cek NIM ganda pada `List(Of Mahasiswa)` memakai loop:

```vb
For Each mhs As Mahasiswa In daftarMahasiswa
    If mhs.Nim = txtNim.Text Then
        errInput.SetError(txtNim, "NIM sudah terdaftar.")
        valid = False
        Exit For
    End If
Next
```

### 4.4 DataTable **[REPO]**

```vb
' Membuat tabel beserta kolom dan datanya
Private Function BuatTabelMahasiswa() As DataTable
    Dim tabel As New DataTable("Mahasiswa")
    tabel.Columns.Add("Nim", GetType(String))            ' kolom: nama + tipe
    tabel.Columns.Add("Nama", GetType(String))
    tabel.Columns.Add("Angkatan", GetType(Integer))
    tabel.Columns.Add("Ipk", GetType(Decimal))
    tabel.Rows.Add("231712001", "Andi Pratama", 2023, 3.45D)   ' urutan nilai = urutan kolom
    Return tabel
End Function

Private Sub FrmDataTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    tabelMahasiswa = BuatTabelMahasiswa()
    bsMahasiswa.DataSource = tabelMahasiswa
    dgvMahasiswa.DataSource = bsMahasiswa
End Sub
```

Tipe kolom penting: kolom `Integer`/`Decimal` bisa **diurutkan dan dijumlahkan sebagai angka**; kalau semuanya String, `100` dianggap lebih kecil dari `20`.

Membaca dan menulis isi `DataRow`:

```vb
baris("KodeBuku").ToString()      ' baca (hasilnya Object, ubah dulu)
baris("Stok") = 10                ' tulis
```

### 4.5 Merapikan kolom grid **[REPO]**

Dipanggil **setelah** `DataSource` terisi.

```vb
' Merapikan judul, lebar, format, dan perataan kolom
Private Sub AturKolom()
    dgvMahasiswa.Columns("Nim").HeaderText = "NIM"                    ' ubah judul kolom
    dgvMahasiswa.Columns("Ipk").HeaderText = "IPK"
    dgvMahasiswa.Columns("Ipk").DefaultCellStyle.Format = "N2"          ' selalu 2 desimal
    dgvMahasiswa.Columns("Ipk").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    dgvMahasiswa.Columns("Angkatan").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    dgvMahasiswa.Columns("Nama").FillWeight = 200                      ' kolom Nama 2x lebih lebar
    dgvMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill   ' memenuhi lebar grid
End Sub
```

Nama di `Columns("...")` harus **sama persis** dengan nama kolom DataTable / nama Property Class.

### 4.6 Filter dan pencarian (paling penting) **[REPO]**

`bsX.Filter` adalah **teks ekspresi**, bukan SQL ke database. Diproses di memori. Contoh teks yang sah:

| Kebutuhan | Isi `bsX.Filter` |
|---|---|
| nama mengandung kata | `Nama LIKE '%sari%'` |
| nama atau NIM | `Nama LIKE '%sari%' OR Nim LIKE '%sari%'` |
| kategori tepat | `Kategori = 'Fiksi'` |
| stok habis | `Stok = 0` |
| stok kurang dari 5 **[UMUM]** | `Stok < 5` |
| teks **dan** kategori | `(Judul LIKE '%an%' OR Penulis LIKE '%an%') AND Kategori = 'Fiksi'` |
| tampilkan semua | `""` (kosong) atau `bsX.RemoveFilter()` |

Aturan tulis: teks diapit `'...'`, angka tanpa kutip, **kurung** wajib kalau `OR` digabung dengan `AND`, dan ada spasi di sekitar `AND`/`OR`.

**Bahaya tanda kutip.** Kalau pengguna mengetik `'`, teks filter menjadi rusak dan program error. Karena itu teks pencarian **harus diamankan** dulu:

```vb
' Mengamankan karakter khusus agar aman dipakai di bsX.Filter
' Kutip tunggal digandakan; [ ] * % dibungkus kurung siku.
Public Function AmankanTeksFilter(teks As String) As String
    Dim hasil As String = ""
    For Each karakter As Char In teks
        Select Case karakter
            Case "'"c
                hasil &= "''"
            Case "["c, "]"c, "*"c, "%"c
                hasil &= "[" & karakter.ToString() & "]"
            Case Else
                hasil &= karakter.ToString()
        End Select
    Next
    Return hasil
End Function
```

Letakkan di Module (misal `ModPencarian.vb`) atau di dalam form. Soal biasanya mengizinkan menyalin dari contoh kelas.

**Filter gabungan (dua syarat, AND hanya jika dua-duanya ada)**: kumpulkan syarat yang aktif ke `List`, lalu sambung dengan `String.Join`:

```vb
' Menyusun filter dari teks pencarian dan kategori, lalu menerapkannya
Private Sub TerapkanFilter()
    Dim syarat As New List(Of String)
    Dim kata As String = AmankanTeksFilter(txtCari.Text.Trim())

    If kata <> "" Then
        syarat.Add("(Judul LIKE '%" & kata & "%' OR Penulis LIKE '%" & kata & "%')")
    End If
    If cboFilterKategori.SelectedIndex > 0 Then                 ' indeks 0 = "Semua"
        syarat.Add("Kategori = '" & cboFilterKategori.Text & "'")
    End If
    ' syarat.Add("Stok = 0") bila chkStokHabis.Checked  (tantangan)

    bsBuku.Filter = String.Join(" AND ", syarat)                ' daftar kosong = tampilkan semua
    PerbaruiRingkasan()
End Sub

' Pencarian berjalan saat mengetik
Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
    TerapkanFilter()
End Sub

' Filter kategori berubah
Private Sub cboFilterKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilterKategori.SelectedIndexChanged
    TerapkanFilter()
End Sub
```

Kenapa pola `List + Join` bagus: syarat baru (misal checkbox stok habis) tinggal `syarat.Add(...)` tanpa merusak syarat lain.

**Filter pada kolom angka dengan LIKE [UMUM]:** `LIKE` hanya untuk teks. Kalau kolom bertipe Integer dan ingin dicari dengan LIKE, ubah dulu: `Convert(Tahun, 'System.String') LIKE '%20%'`. Cara lain, cukup pakai pembanding angka (`Tahun >= 2010`).

### 4.7 Pencarian dengan perulangan pada `List(Of T)` **[REPO]**

`List(Of T)` **tidak mendukung** `BindingSource.Filter`. Solusinya loop, kumpulkan hasil ke list baru, lalu pasang list baru itu sebagai `DataSource`.

```vb
' Mencari nama/NIM dengan perulangan, tidak peka huruf besar-kecil
Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
    Dim kata As String = txtCari.Text.Trim().ToLower()
    Dim hasil As New List(Of Mahasiswa)
    For Each mhs As Mahasiswa In daftarMahasiswa
        If mhs.Nama.ToLower().Contains(kata) OrElse mhs.Nim.Contains(kata) Then
            hasil.Add(mhs)
        End If
    Next
    bsMahasiswa.DataSource = hasil
    lblJumlah.Text = "Menampilkan " & hasil.Count.ToString() & " dari " &
                     daftarMahasiswa.Count.ToString() & " data"
End Sub
```

`Contains("")` bernilai True untuk semua teks, jadi kotak kosong otomatis menampilkan semua data.

### 4.8 Ringkasan: jumlah dan total dari baris yang sedang tampil **[REPO]**

```vb
' Memperbarui "Menampilkan X dari Y buku" dan total stok yang sedang tampil
Private Sub PerbaruiRingkasan()
    Dim totalStok As Integer = 0
    For Each baris As DataGridViewRow In dgvBuku.Rows          ' hanya baris yang lolos filter
        totalStok += CInt(baris.Cells("Stok").Value)           ' Value bertipe Object, bungkus CInt
    Next
    lblJumlah.Text = "Menampilkan " & dgvBuku.Rows.Count.ToString() &
                     " dari " & tabelBuku.Rows.Count.ToString() & " buku"
    lblTotalStok.Text = "Total stok: " & totalStok.ToString()
End Sub
```

- X = `dgvBuku.Rows.Count` (yang tampil), Y = `tabelBuku.Rows.Count` (semua).
- Panggil `PerbaruiRingkasan` dari **dua tempat**: setiap filter berubah dan setiap data ditambah.
- Alternatif cepat `tabel.Compute("SUM(Stok)", filter)` **tidak disarankan**: hasilnya `DBNull` saat tidak ada baris sehingga `CInt` error, dan soal biasanya meminta perulangan pada `dgvBuku.Rows`.

### 4.9 Urutkan dan checkbox filter **[REPO, tantangan]**

```vb
' Mengatur urutan tampilan grid
Private Sub cboUrut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUrut.SelectedIndexChanged
    Select Case cboUrut.SelectedIndex
        Case 1
            bsBuku.Sort = "Judul ASC"
        Case 2
            bsBuku.Sort = "Tahun DESC"
        Case 3
            bsBuku.Sort = "Stok DESC"
        Case Else
            bsBuku.Sort = ""            ' urutan awal
    End Select
End Sub
```

Di `Load`, atur `cboUrut.SelectedIndex = 0` **setelah** binding selesai.

Hanya stok habis: di `TerapkanFilter`, sebelum baris `bsBuku.Filter = ...`, tambahkan:

```vb
If chkStokHabis.Checked Then syarat.Add("Stok = 0")
```

lalu buat event `chkStokHabis_CheckedChanged` yang memanggil `TerapkanFilter()`.

### 4.10 SOLUSI LENGKAP Tugas 8: Inventaris Buku Perpustakaan **[REPO + disusun dari spesifikasi]**

**Aliran data:** `tabelBuku (DataTable)` → `bsBuku (BindingSource)` → `dgvBuku (tampilan)`.

**Kontrol di Designer:**

| Kontrol | (Name) | Pengaturan |
|---|---|---|
| Label | `lblJudulForm` | Text `Inventaris Buku Perpustakaan`, Segoe UI 14pt Bold |
| Label + TextBox | `lblKodeBuku` / `txtKodeBuku` | `MaxLength` 6 |
| Label + TextBox | `lblJudul` / `txtJudul` | |
| Label + TextBox | `lblPenulis` / `txtPenulis` | |
| Label + ComboBox | `lblKategori` / `cboKategori` | DropDownList; Items: Fiksi, Nonfiksi, Referensi, Majalah |
| Label + TextBox | `lblTahun` / `txtTahun` | `MaxLength` 4 |
| Label + TextBox | `lblStok` / `txtStok` | `MaxLength` 5 |
| Button | `btnTambah` | Text `Tambah` |
| Button | `btnBersihkan` | Text `Bersihkan`, `CausesValidation = False` |
| Label + TextBox | `lblCari` / `txtCari` | |
| ComboBox | `cboFilterKategori` | DropDownList; Items: Semua, Fiksi, Nonfiksi, Referensi, Majalah |
| DataGridView | `dgvBuku` | `ReadOnly = True`, `AllowUserToAddRows = False`, `SelectionMode = FullRowSelect`, `MultiSelect = False` (disarankan juga `AllowUserToDeleteRows = False`) |
| Label | `lblJumlah`, `lblTotalStok` | `AutoSize = False`, `Size` cukup lebar |
| BindingSource | `bsBuku` | Toolbox grup **Data**; **jangan** isi DataSource di Designer |
| ErrorProvider | `errBuku` | Toolbox grup **Components** |

Tata letak yang aman: form lebar (`ClientSize` 900; 620), isian di atas, baris pencarian di tengah, grid besar (860; 300) di bawah, dua label ringkasan paling bawah.

**Kode `FrmInventaris.vb`:**

```vb
Option Strict On

' Form inventaris buku: tabel data, pencarian gabungan, dan ringkasan stok
Public Class FrmInventaris

    ' Tabel data buku di memori (pengganti database)
    Private ReadOnly tabelBuku As New DataTable()

    ' Membuat kolom-kolom tabelBuku beserta tipe datanya
    Private Sub BuatTabel()
        tabelBuku.Columns.Add("KodeBuku", GetType(String))
        tabelBuku.Columns.Add("Judul", GetType(String))
        tabelBuku.Columns.Add("Penulis", GetType(String))
        tabelBuku.Columns.Add("Kategori", GetType(String))
        tabelBuku.Columns.Add("Tahun", GetType(Integer))
        tabelBuku.Columns.Add("Stok", GetType(Integer))
    End Sub

    ' Mengisi data awal (minimal 10 buku, 4 kategori terwakili, minimal 2 buku stok 0)
    Private Sub IsiDataAwal()
        tabelBuku.Rows.Add("BK0001", "Laskar Pelangi", "Andrea Hirata", "Fiksi", 2005, 5)
        tabelBuku.Rows.Add("BK0002", "Bumi Manusia", "Pramoedya Ananta Toer", "Fiksi", 1980, 0)
        tabelBuku.Rows.Add("BK0003", "Negeri 5 Menara", "Ahmad Fuadi", "Fiksi", 2009, 3)
        tabelBuku.Rows.Add("BK0004", "Sapiens", "Yuval Noah Harari", "Nonfiksi", 2011, 4)
        tabelBuku.Rows.Add("BK0005", "Atomic Habits", "James Clear", "Nonfiksi", 2018, 6)
        tabelBuku.Rows.Add("BK0006", "Filosofi Teras", "Henry Manampiring", "Nonfiksi", 2018, 0)
        tabelBuku.Rows.Add("BK0007", "Kamus Besar Bahasa Indonesia", "Tim Penyusun", "Referensi", 2016, 2)
        tabelBuku.Rows.Add("BK0008", "Ensiklopedia Sains", "Tim Penyusun", "Referensi", 2012, 1)
        tabelBuku.Rows.Add("BK0009", "Majalah Tempo Edisi Khusus", "Redaksi Tempo", "Majalah", 2020, 7)
        tabelBuku.Rows.Add("BK0010", "Majalah Sains Populer", "Redaksi Sains", "Majalah", 2021, 3)
    End Sub

    ' Menyiapkan data, menghubungkan ke grid, dan mengatur tampilan awal
    Private Sub FrmInventaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuatTabel()
        IsiDataAwal()
        bsBuku.DataSource = tabelBuku        ' DataTable -> BindingSource
        dgvBuku.DataSource = bsBuku          ' BindingSource -> grid
        AturKolomGrid()                      ' HARUS setelah DataSource terisi
        cboKategori.SelectedIndex = -1
        cboFilterKategori.SelectedIndex = 0  ' pilih "Semua" (memicu filter, jadi DataSource harus sudah terisi)
        TerapkanFilter()                     ' hitung ringkasan awal
    End Sub

    ' Merapikan judul, lebar, dan perataan kolom
    Private Sub AturKolomGrid()
        dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBuku.Columns("KodeBuku").HeaderText = "Kode Buku"
        dgvBuku.Columns("Judul").FillWeight = 200
        dgvBuku.Columns("Tahun").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvBuku.Columns("Stok").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    ' True jika kode sudah ada di tabelBuku (dicek dengan perulangan)
    Private Function KodeSudahAda(kode As String) As Boolean
        For Each baris As DataRow In tabelBuku.Rows
            If baris("KodeBuku").ToString() = kode Then Return True
        Next
        Return False
    End Function

    ' Memeriksa semua isian sekaligus. True jika semuanya valid.
    Private Function ValidasiInput() As Boolean
        errBuku.Clear()
        Dim valid As Boolean = True
        Dim kode As String = txtKodeBuku.Text.Trim().ToUpper()

        If Not KodeBukuValid(kode) Then
            errBuku.SetError(txtKodeBuku, "Kode harus 'BK' + 4 digit, contoh BK0012.")
            valid = False
        ElseIf KodeSudahAda(kode) Then
            errBuku.SetError(txtKodeBuku, "Kode buku sudah ada di inventaris.")
            valid = False
        End If

        If Kosong(txtJudul.Text) Then
            errBuku.SetError(txtJudul, "Judul wajib diisi.")
            valid = False
        End If

        If Kosong(txtPenulis.Text) Then
            errBuku.SetError(txtPenulis, "Penulis wajib diisi.")
            valid = False
        End If

        If cboKategori.SelectedIndex = -1 Then
            errBuku.SetError(cboKategori, "Pilih salah satu kategori.")
            valid = False
        End If

        Dim tahun As Integer
        If Not Integer.TryParse(txtTahun.Text, tahun) OrElse tahun < 1900 OrElse tahun > Date.Today.Year Then
            errBuku.SetError(txtTahun, "Tahun harus bilangan bulat 1900 s.d. tahun ini.")
            valid = False
        End If

        Dim stok As Integer
        If Not Integer.TryParse(txtStok.Text, stok) OrElse stok < 0 Then
            errBuku.SetError(txtStok, "Stok harus bilangan bulat 0 atau lebih.")
            valid = False
        End If

        Return valid
    End Function

    ' Menambah buku baru jika semua isian valid
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Not ValidasiInput() Then Return

        tabelBuku.Rows.Add(txtKodeBuku.Text.Trim().ToUpper(), txtJudul.Text.Trim(),
                           txtPenulis.Text.Trim(), cboKategori.Text,
                           Integer.Parse(txtTahun.Text), Integer.Parse(txtStok.Text))
        BersihkanForm()
        PerbaruiRingkasan()          ' grid sudah otomatis menampilkan buku baru lewat bsBuku
    End Sub

    ' Mengosongkan isian dan semua tanda error
    Private Sub BersihkanForm()
        txtKodeBuku.Clear()
        txtJudul.Clear()
        txtPenulis.Clear()
        cboKategori.SelectedIndex = -1
        txtTahun.Clear()
        txtStok.Clear()
        errBuku.Clear()
        txtKodeBuku.Focus()
    End Sub

    ' Tombol Bersihkan
    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        BersihkanForm()
    End Sub

    ' Mengamankan karakter khusus agar aman dipakai di bsBuku.Filter
    Private Function AmankanFilter(teks As String) As String
        Dim hasil As String = ""
        For Each karakter As Char In teks
            Select Case karakter
                Case "'"c
                    hasil &= "''"
                Case "*"c, "%"c, "["c, "]"c
                    hasil &= "[" & karakter.ToString() & "]"
                Case Else
                    hasil &= karakter.ToString()
            End Select
        Next
        Return hasil
    End Function

    ' Menyusun filter dari teks pencarian dan kategori, lalu menerapkannya
    Private Sub TerapkanFilter()
        Dim syarat As New List(Of String)
        Dim kata As String = AmankanFilter(txtCari.Text.Trim())

        If kata <> "" Then
            syarat.Add("(Judul LIKE '%" & kata & "%' OR Penulis LIKE '%" & kata & "%')")
        End If
        If cboFilterKategori.SelectedIndex > 0 Then
            syarat.Add("Kategori = '" & cboFilterKategori.Text & "'")
        End If

        bsBuku.Filter = String.Join(" AND ", syarat)
        PerbaruiRingkasan()
    End Sub

    ' Pencarian berjalan saat mengetik
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        TerapkanFilter()
    End Sub

    ' Filter kategori berubah
    Private Sub cboFilterKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilterKategori.SelectedIndexChanged
        TerapkanFilter()
    End Sub

    ' Memperbarui "Menampilkan X dari Y buku" dan total stok yang sedang tampil
    Private Sub PerbaruiRingkasan()
        Dim totalStok As Integer = 0
        For Each baris As DataGridViewRow In dgvBuku.Rows
            totalStok += CInt(baris.Cells("Stok").Value)
        Next
        lblJumlah.Text = "Menampilkan " & dgvBuku.Rows.Count.ToString() &
                         " dari " & tabelBuku.Rows.Count.ToString() & " buku"
        lblTotalStok.Text = "Total stok: " & totalStok.ToString()
    End Sub

End Class
```

Salin juga `ModValidasi.vb` (Bagian 3.2) ke proyek ini; ia berisi `Kosong`, `SemuaDigit`, dan `KodeBukuValid`.

**Urutan yang tidak boleh terbalik:**
1. `AturKolomGrid` sesudah `dgvBuku.DataSource` terisi (sebelumnya kolom belum ada, program error).
2. `DataSource` terisi sebelum `cboFilterKategori.SelectedIndex = 0`, karena baris itu memicu event filter yang memakai `bsBuku`.
3. Grid diisi lewat `bsBuku`, **bukan** `dgvBuku.Rows.Add`.

**Tabel uji Tugas 8 (dan screenshot yang diminta):**

| Uji | Hasil yang benar |
|---|---|
| Tambah `BK0011` dengan data valid | buku muncul di grid, ringkasan bertambah → **screenshot 1** |
| Masukkan `BK0011` lagi | ikon merah "Kode buku sudah ada" → **screenshot 2** |
| Cari `an`, kategori Fiksi | hanya buku Fiksi yang mengandung "an"; `lblJumlah` dan `lblTotalStok` sesuai → **screenshot 3** |
| Ketik `'` di kotak cari | tidak error; hasil 0 buku → **screenshot 4** |
| Kosongkan kotak cari, kategori Semua | semua buku tampil lagi |
| Isian kosong lalu Tambah | ikon merah di semua isian yang salah |
| Tahun `1850` atau stok `-1` | ikon merah di isian itu |

Contoh hitungan dengan data awal di atas (10 buku): pencarian `an` di kategori Fiksi cocok dengan *Laskar Pelangi* (stok 5) dan *Bumi Manusia* (stok 0), jadi `lblJumlah` = "Menampilkan 2 dari 10 buku" dan `lblTotalStok` = "Total stok: 5". *Negeri 5 Menara* tidak ikut karena judul dan penulisnya tidak memuat "an". Angka di soal (2 dari 11 buku, total 8) berasal dari data milik soal, jadi **hitung manual dulu dari datamu sendiri** untuk memastikan label sudah benar. Pencocokan `LIKE` pada `DataTable` tidak peka huruf besar-kecil secara bawaan **[UMUM]**.

---
## Bagian 5: Variasi Soal yang Mungkin Keluar

> Semua isi bagian ini **[VARIASI]** atau **[UMUM]**: tidak tertulis di repo, tetapi mengikuti pola tugas dan hanya memakai konsep dasar. Pakai bila soal ujian meminta fitur yang tidak ada di Tugas 7 dan 8.

### 5.1 Hapus data terpilih

```vb
' Menghapus data yang sedang dipilih di grid setelah konfirmasi
Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
    If bsBuku.Current Is Nothing Then                     ' tidak ada baris terpilih / data kosong
        MessageBox.Show("Pilih data yang akan dihapus.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return
    End If
    If MessageBox.Show("Hapus data terpilih?", "Konfirmasi", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question) = DialogResult.Yes Then
        bsBuku.RemoveCurrent()
        tabelBuku.AcceptChanges()      ' hanya untuk DataTable: bersihkan baris berstatus Deleted
        PerbaruiRingkasan()
    End If
End Sub
```

- Untuk `List(Of T)` yang terikat `BindingSource`, cukup `bsX.RemoveCurrent()`.
- **Jebakan DataTable:** baris yang dihapus bisa masih tercatat berstatus *Deleted*, dan membaca `baris("Kolom")` dari baris itu di loop menghasilkan `DeletedRowInaccessibleException`. `AcceptChanges()` membereskannya.
- Kalau ada `List(Of String)` pencatat kode (seperti `daftarKodeDipinjam`), **hapus juga dari situ**, kalau tidak, kode itu tetap dianggap ganda.

### 5.2 Edit data (pilih baris → isi form → simpan perubahan)

```vb
Private kodeSedangDiedit As String = ""      ' kosong = mode tambah

' Mengisi form dari baris yang diklik
Private Sub dgvBuku_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBuku.CellClick
    If e.RowIndex < 0 Then Return             ' klik pada header kolom
    Dim baris As DataGridViewRow = dgvBuku.Rows(e.RowIndex)
    kodeSedangDiedit = baris.Cells("KodeBuku").Value.ToString()
    txtKodeBuku.Text = kodeSedangDiedit
    txtJudul.Text = baris.Cells("Judul").Value.ToString()
    txtPenulis.Text = baris.Cells("Penulis").Value.ToString()
    cboKategori.SelectedIndex = cboKategori.FindStringExact(baris.Cells("Kategori").Value.ToString())
    txtTahun.Text = baris.Cells("Tahun").Value.ToString()
    txtStok.Text = baris.Cells("Stok").Value.ToString()
End Sub

' Menyimpan perubahan pada baris yang sedang diedit
Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
    If kodeSedangDiedit = "" Then Return
    If Not ValidasiInput() Then Return
    For Each baris As DataRow In tabelBuku.Rows
        If baris("KodeBuku").ToString() = kodeSedangDiedit Then
            baris("Judul") = txtJudul.Text.Trim()
            baris("Penulis") = txtPenulis.Text.Trim()
            baris("Kategori") = cboKategori.Text
            baris("Tahun") = Integer.Parse(txtTahun.Text)
            baris("Stok") = Integer.Parse(txtStok.Text)
            Exit For
        End If
    Next
    kodeSedangDiedit = ""
    BersihkanForm()
    PerbaruiRingkasan()
End Sub
```

Di `ValidasiInput`, cek duplikat kode harus **dilewati** untuk baris yang sedang diedit:

```vb
ElseIf kode <> kodeSedangDiedit AndAlso KodeSudahAda(kode) Then
```

Grid ikut berubah otomatis karena terikat lewat `BindingSource`.

### 5.3 Rata-rata, maksimum, minimum, jumlah per kategori (dengan perulangan)

```vb
' Menghitung rata-rata dan nilai tertinggi dari baris yang sedang tampil
Private Sub HitungStatistik()
    Dim total As Decimal = 0D
    Dim tertinggi As Decimal = 0D
    For Each baris As DataGridViewRow In dgvMahasiswa.Rows
        Dim nilai As Decimal = CDec(baris.Cells("Ipk").Value)
        total += nilai
        If nilai > tertinggi Then tertinggi = nilai
    Next
    Dim rata As Decimal = 0D
    If dgvMahasiswa.Rows.Count > 0 Then               ' hindari pembagian dengan nol
        rata = total / dgvMahasiswa.Rows.Count
    End If
    lblRata.Text = "Rata-rata IPK: " & rata.ToString("0.00")
    lblMaks.Text = "IPK tertinggi: " & tertinggi.ToString("0.00")
End Sub
```

Menghitung jumlah per kategori: satu variabel penghitung per kategori dan `Select Case` di dalam loop.

```vb
Dim jmlFiksi As Integer = 0
For Each baris As DataGridViewRow In dgvBuku.Rows
    Select Case baris.Cells("Kategori").Value.ToString()
        Case "Fiksi"
            jmlFiksi += 1
        ' Case "Nonfiksi" dst.
    End Select
Next
```

Total nilai dua kolom (misal harga x stok): `total += CDec(baris.Cells("Harga").Value) * CInt(baris.Cells("Stok").Value)`.

### 5.4 Filter angka (kurang dari, rentang)

```vb
' Menambah syarat "Stok < batas" jika kotak batas berisi bilangan valid
Dim batas As Integer
If Integer.TryParse(txtBatasStok.Text, batas) Then
    syarat.Add("Stok < " & batas.ToString())
End If
' Rentang tahun
syarat.Add("Tahun >= 2010 AND Tahun <= 2020")
```

**Jebakan desimal di filter:** angka pecahan harus ditulis dengan **titik**, padahal `ToString()` di Windows berbahasa Indonesia menghasilkan **koma** dan filter jadi error. Pakai `InvariantCulture`:

```vb
Imports System.Globalization      ' di atas file
...
syarat.Add("Ipk >= " & ipkMin.ToString(CultureInfo.InvariantCulture))
```

### 5.5 ListBox: hapus yang dipilih atau ambil bagian dari item

```vb
' Mengembalikan buku: hapus item terpilih dan kodenya dari daftar kode
Private Sub btnKembalikan_Click(sender As Object, e As EventArgs) Handles btnKembalikan.Click
    If lstPeminjaman.SelectedIndex = -1 Then Return
    Dim kode As String = lstPeminjaman.SelectedItem.ToString().Split("|"c)(0).Trim()   ' bagian sebelum "|"
    daftarKodeDipinjam.Remove(kode)
    lstPeminjaman.Items.RemoveAt(lstPeminjaman.SelectedIndex)
    lblStatus.Text = "Jumlah peminjaman: " & lstPeminjaman.Items.Count.ToString()
End Sub
```

### 5.6 Kontrol lain dalam validasi

```vb
' RadioButton: salah satu wajib dipilih
If Not rdoLaki.Checked AndAlso Not rdoPerempuan.Checked Then
    errInput.SetError(grpJenisKelamin, "Pilih jenis kelamin.")
    valid = False
End If

' CheckBox persetujuan
If Not chkSetuju.Checked Then
    errInput.SetError(chkSetuju, "Centang persetujuan.")
    valid = False
End If

' DateTimePicker: tanggal tidak boleh sebelum hari ini
If dtpTanggal.Value.Date < Date.Today Then
    errInput.SetError(dtpTanggal, "Tanggal tidak boleh sebelum hari ini.")
    valid = False
End If

' Email sederhana
If Not (txtEmail.Text.Contains("@") AndAlso txtEmail.Text.Contains(".")) Then
    errInput.SetError(txtEmail, "Format email tidak valid.")
    valid = False
End If
```

### 5.7 Tambahan Module validasi (untuk aturan baru)

```vb
' True jika semua karakter adalah digit dan panjangnya di antara minimal dan maksimal (misal nomor HP 10-13)
Public Function DigitRentang(teks As String, minimal As Integer, maksimal As Integer) As Boolean
    If teks.Length < minimal OrElse teks.Length > maksimal Then Return False
    For Each karakter As Char In teks
        If karakter < "0"c OrElse karakter > "9"c Then Return False
    Next
    Return True
End Function

' True jika teks hanya berisi huruf dan spasi (misal untuk nama)
Public Function HurufSaja(teks As String) As Boolean
    For Each karakter As Char In teks
        If Not (Char.IsLetter(karakter) OrElse karakter = " "c) Then Return False
    Next
    Return True
End Function
```

### 5.8 Ekspor isi DataGridView ke CSV (bukan dari ListBox)

```vb
' Menulis semua baris grid ke CSV, sel dipisah titik koma
Private Sub btnEkspor_Click(sender As Object, e As EventArgs) Handles btnEkspor.Click
    If dgvBuku.Rows.Count = 0 Then
        MessageBox.Show("Tidak ada data untuk diekspor.", "Ekspor Dibatalkan")
        Return
    End If
    Dim penulis As StreamWriter = Nothing
    Try
        penulis = New StreamWriter(lokasiEkspor)
        penulis.WriteLine("KodeBuku;Judul;Penulis;Kategori;Tahun;Stok")
        For Each baris As DataGridViewRow In dgvBuku.Rows
            Dim kolom As New List(Of String)
            For Each sel As DataGridViewCell In baris.Cells
                kolom.Add(sel.Value.ToString())
            Next
            penulis.WriteLine(String.Join(";", kolom))
        Next
    Catch ex As IOException
        MessageBox.Show("File sedang dipakai program lain. Tutup lalu coba lagi." & vbCrLf & ex.Message, "Ekspor Gagal")
    Finally
        If penulis IsNot Nothing Then penulis.Close()
    End Try
End Sub
```

---

## Bagian 6: Mengganti Kasus (Adaptasi) dan Soal Latihan

Soal ujian hampir pasti **bukan buku**. Tugas 7 dan 8 sendiri sudah "kasus berbeda dari contoh kelas, konsepnya sama". Jadi kerjakan dengan **mengganti nama**, bukan menulis ulang.

### 6.1 Peta penggantian

| Elemen | Tugas 7 / 8 (buku) | Contoh barang toko | Contoh pegawai | Contoh pasien |
|---|---|---|---|---|
| Kode | `BK` + 4 digit | `BR` + 3 digit | `PG` + 4 digit | `PS` + 5 digit |
| Field teks | Judul, Penulis | NamaBarang, Supplier | Nama, Jabatan | Nama, Keluhan |
| Field angka | Tahun, Stok | Harga, Stok | Gaji, MasaKerja | Umur |
| Kategori (ComboBox) | Fiksi, Nonfiksi... | Elektronik, Pakaian... | Divisi A, B... | Poli Umum, Gigi... |
| Cek ganda | `daftarKodeDipinjam` / `KodeSudahAda` | sama | sama | sama |
| Ringkasan | total stok | total nilai (harga x stok) | total gaji, rata-rata | jumlah pasien |
| Tanggal | tanggal kembali | tanggal kedaluwarsa | tanggal kontrak habis | tanggal kontrol |

### 6.2 Langkah adaptasi (7 langkah)

1. **Tulis daftar field + tipe** dari soal: `Kode:String, Nama:String, Harga:Decimal, Stok:Integer, ...`
2. **Tulis aturan validasi per field** memakai tabel di Bagian 3.3.
3. **Pilih prefix kontrol** dari tabel soal: salin persis nama yang diminta.
4. **Kolom DataTable** = field di langkah 1 (`GetType(String)`, `GetType(Integer)`, `GetType(Decimal)`).
5. **Ganti nama kolom di semua teks**: `Columns("Stok")`, `baris("KodeBuku")`, string filter `"Judul LIKE ..."`. Inilah titik yang paling sering terlewat, dan akan error saat dijalankan, bukan saat build.
6. **Ganti rumus ringkasan** (total/rata-rata).
7. **Cari-ganti** nama fungsi/variabel dengan **Ctrl+H** (Replace in Files atau Current Document), lalu **Rebuild**.

### 6.3 Fungsi kode berformat yang umum (gantikan `KodeBukuValid`)

```vb
' True jika kode berawalan tertentu diikuti sejumlah digit (huruf besar/kecil sama saja)
' Contoh: KodeValid("BR0012", "BR", 4)
Public Function KodeValid(kode As String, awalan As String, jumlahDigit As Integer) As Boolean
    Dim k As String = kode.Trim().ToUpper()
    Dim a As String = awalan.ToUpper()
    If k.Length <> a.Length + jumlahDigit Then Return False      ' cek panjang dulu agar Substring aman
    If Not k.StartsWith(a) Then Return False
    Return SemuaDigit(k.Substring(a.Length), jumlahDigit)
End Function
```

Pemakaian: `If Not KodeValid(txtKode.Text, "BR", 4) Then ...`. Kalau soal menyebut `KodeBukuValid` secara khusus, tetap buat fungsi dengan **nama itu** dan biarkan ia memanggil `KodeValid`.

### 6.4 Latihan A: Inventaris Barang Toko (gaya Tugas 8)

**Soal (rekaan untuk latihan):** form `FrmInventarisBarang`. DataTable `tabelBarang`: KodeBarang (String, "BR" + 3 digit), NamaBarang, Supplier, Kategori (Elektronik/Pakaian/Makanan/ATK), Harga (Decimal), Stok (Integer). Minimal 10 barang. Tambah dengan validasi (harga > 0, stok >= 0, kode unik). Cari nama **atau** supplier + filter kategori, dalam satu `Filter`. `lblJumlah` "Menampilkan X dari Y barang", `lblTotalNilai` = jumlah (harga x stok) dari baris yang tampil. Tanda kutip di pencarian tidak boleh error.

**Peta jawabannya:**
- Salin kerangka **Bagian 4.10** apa adanya, ganti nama (`tabelBuku`→`tabelBarang`, `bsBuku`→`bsBarang`, `dgvBuku`→`dgvBarang`, `errBuku`→`errBarang`, `KodeBuku`→`KodeBarang`, `Judul`→`NamaBarang`, `Penulis`→`Supplier`).
- Kolom `Harga` bertipe `Decimal`, `Tahun` dihapus. Validasi harga memakai `CobaDesimal` dengan rentang `harga <= 0D` sebagai salah.
- Ganti isi `PerbaruiRingkasan`:

```vb
' Memperbarui jumlah barang dan total nilai persediaan yang sedang tampil
Private Sub PerbaruiRingkasan()
    Dim totalNilai As Decimal = 0D
    For Each baris As DataGridViewRow In dgvBarang.Rows
        totalNilai += CDec(baris.Cells("Harga").Value) * CInt(baris.Cells("Stok").Value)
    Next
    lblJumlah.Text = "Menampilkan " & dgvBarang.Rows.Count.ToString() &
                     " dari " & tabelBarang.Rows.Count.ToString() & " barang"
    lblTotalNilai.Text = "Total nilai: " & totalNilai.ToString("N0")
End Sub
```

- Filter: `"(NamaBarang LIKE '%" & kata & "%' OR Supplier LIKE '%" & kata & "%')"`.
- Format kolom harga di `AturKolomGrid`: `dgvBarang.Columns("Harga").DefaultCellStyle.Format = "N0"`.

### 6.5 Latihan B: Peminjaman Alat Laboratorium atau Kontrol Pasien (gaya Tugas 7)

**Soal (rekaan):** `FrmKontrolPasien`. Kontrol: `txtKodePasien` ("PS" + 5 digit, huruf kecil diterima), `txtNamaPasien` (minimal 3 karakter), `txtUmur` (bilangan bulat 0 sampai 120, `Integer.TryParse`), `cboPoli`, `txtHariKontrol` (1 sampai 30), `btnDaftar`, `btnBersihkan`, `lstPasien`, `btnEkspor`, `lblStatus`, `errPasien`. Pasien yang sama tidak boleh didaftarkan dua kali ("Pasien sudah terdaftar."). Format baris: `PS00012 | Rina Lubis | 32 tahun | Poli Gigi | kontrol 05/11/2026`.

**Peta jawabannya:** salin **Bagian 3.8** lalu:
- `daftarKodeDipinjam` → `daftarKodePasien`, pesan duplikat → "Pasien sudah terdaftar."
- `KodeBukuValid(kode)` → `KodeValid(kode, "PS", 5)`.
- Aturan umur: `Not Integer.TryParse(txtUmur.Text, umur) OrElse umur < 0 OrElse umur > 120`.
- Aturan hari kontrol: sama seperti lama pinjam, rentang 1 sampai 30.
- Tanggal: `Date.Today.AddDays(hari).ToString("dd/MM/yyyy")`.
- Item list: `kode & " | " & nama & " | " & umur.ToString() & " tahun | " & cboPoli.Text & " | kontrol " & tgl`.
- Ekspor: header baru (`KodePasien;Nama;Umur;Poli;TanggalKontrol`), file `kontrol-pasien.csv`, dua `Catch` yang sama.

---
## Bagian 7: Error Umum dan Obatnya

Buka **View → Error List** dan selalu baca pesan **paling atas** dulu; satu kesalahan sering memunculkan banyak error turunan.

| Gejala / pesan | Penyebab | Obat |
|---|---|---|
| `Statement is not valid in a namespace` | Function/Sub berada di luar `Module`/`Class` (atau `End Class` terlalu awal) **[REPO, kejadian nyata]** | Bungkus fungsi dengan `Public Module ... End Module`, atau pindahkan Sub ke antara `Public Class` dan `End Class` |
| `'SemuaDigit' is not declared` | Fungsi belum disalin ke `ModValidasi` **[REPO, kejadian nyata]** | Salin `Kosong`, `SemuaDigit`, `KodeBukuValid` dari Bagian 3.2 |
| `'txtNama' is not declared` | Kontrol belum dibuat, nama beda ejaan, atau kontrolnya ada di form lain | Cek `(Name)` di Properties dan ejaan di kode |
| Tombol diklik tidak terjadi apa-apa | Tidak ada `Handles btnX.Click` (nama diganti setelah double-click) | Tambahkan `Handles btnX.Click` pada Sub, atau hapus Sub lalu double-click ulang |
| `Handles clause requires a WithEvents variable` | Kontrol di `Handles` tidak ada / sudah di-rename | Samakan nama kontrol |
| `... is already declared` / `... multiple definitions` | Double-click dua kali, Sub kembar | Hapus salah satu |
| `Option Strict On disallows implicit conversions from 'String' to 'Integer'` | Menugaskan teks ke angka tanpa konversi | `Integer.Parse(...)`, `Integer.TryParse(...)`, `CInt(...)`, `.ToString()` |
| `Option Strict On disallows late binding` | Memanggil anggota yang tidak ada pada tipe `Object` | Ubah dulu ke tipe yang benar atau panggil `.ToString()` |
| Startup form/object tidak menampilkan form barunya | Rename belum tersimpan atau belum di-build **[REPO, kejadian nyata]** | Ctrl+Shift+S, **Build → Rebuild Solution**, tutup dan buka lagi dialog Properties |
| `Rows cannot be programmatically added ... when the control is data-bound` | `dgv.Rows.Add` padahal grid sudah terikat `DataSource` | Tambahkan ke sumber data (`tabel.Rows.Add` / `bs.Add`) |
| `Column named X cannot be found` / `Object reference not set` di `AturKolom` | Nama kolom salah ketik, atau `AturKolom` dipanggil **sebelum** `DataSource` diisi | Samakan nama kolom; panggil `AturKolom` sesudah `dgv.DataSource = bs` |
| `Syntax error: Missing operand after 'Judul' operator` (dan sejenisnya) saat mengetik | Tanda kutip pengguna merusak teks Filter | Lewatkan teks pencarian melalui `AmankanFilter` |
| Filter error saat angka pecahan | `ToString()` menghasilkan koma | `ToString(CultureInfo.InvariantCulture)` |
| Grid tidak berubah setelah menambah data | Menambah ke `List` langsung, bukan lewat `BindingSource`; atau lupa memasang `DataSource` | `bs.Add(obj)` atau tambah ke `DataTable` yang terikat |
| Kolom ganda di grid | Kolom dibuat manual di Designer **dan** `DataSource` mengisi otomatis | Untuk grid terikat, **jangan** buat kolom manual (hapus lewat Edit Columns) |
| Jumlah baris lebih satu dari seharusnya | `AllowUserToAddRows = True` (baris kosong ikut terhitung) | Set `False` di Designer |
| Ikon merah tidak hilang | Lupa `errX.Clear()` di awal `ValidasiInput` atau di `BersihkanForm` | Tambahkan `Clear()` |
| Klik Bersihkan malah memunculkan ikon merah | `CausesValidation` tombol masih `True` dan ada event `Validating` | Set `CausesValidation = False` pada tombol itu |
| Teks label terpotong | `AutoSize = False` dengan `Size` kecil | Perbesar `Size` (atau `AutoSize = True` bila soal tidak melarang) |
| Program crash saat `Integer.Parse` | Dipakai sebelum validasi atau input tidak divalidasi | Panggil `ValidasiInput` dulu dan `Return` bila gagal |
| `DeletedRowInaccessibleException` | Loop membaca baris `DataTable` yang sudah dihapus | `tabel.AcceptChanges()` setelah menghapus |
| `DivideByZeroException` | Pembagian bulat dengan nol | Cek penyebut sebelum membagi |
| Designer tidak mau terbuka ("designer could not be shown...") **[UMUM]** | Ada error build atau class form rusak (`Public Class` terhapus) | Perbaiki semua error di Error List, Rebuild, tutup tab form lalu buka lagi |
| Setelah menghapus kontrol muncul error di kode | Sub lama yang `Handles` kontrol itu masih ada | Hapus Sub tersebut |

---

## Bagian 8: Trik Visual Studio dan Hacks

### Pintasan keyboard **[UMUM]**

| Tombol | Fungsi |
|---|---|
| `F5` / `Ctrl+F5` | jalankan dengan debug / tanpa debug (lebih cepat) |
| `Shift+F5` | hentikan program |
| `F7` / `Shift+F7` | pindah dari Designer ke kode / dari kode ke Designer |
| `Ctrl+S` / `Ctrl+Shift+S` | simpan file / simpan semua |
| `Ctrl+Shift+B` | build solution |
| `Ctrl+K, Ctrl+D` | rapikan indentasi dokumen |
| `Ctrl+K, Ctrl+C` / `Ctrl+K, Ctrl+U` | beri / hapus komentar pada baris terpilih |
| `Ctrl+.` | quick fix (sering menawarkan konversi yang benar untuk error Option Strict) |
| `Ctrl+Spasi` | IntelliSense |
| `F2` | ganti nama variabel/fungsi di seluruh proyek |
| `Ctrl+H` | cari dan ganti |
| `F9`, `F10`, `F11` | breakpoint, langkah demi langkah (lewati / masuk) |
| `F4` | buka jendela Properties |

### Trik di Designer **[UMUM]**

- **Pilih beberapa kontrol sekaligus** (tahan `Ctrl`, atau tarik kotak seleksi), lalu atur satu properti untuk semuanya (Font, `CausesValidation`, `AutoSize`).
- **Salin kontrol**: `Ctrl+C`, `Ctrl+V`, lalu langsung ganti `(Name)` dan `Text`. Cepat untuk deretan label dan TextBox.
- Jendela Properties: klik ikon **urut abjad** supaya `(Name)` ada di paling atas; ikon **petir** untuk Events (dipakai membuat `Validating`).
- Menu **Format → Align / Make Same Size / Vertical Spacing** untuk merapikan; atur ukuran presisi lewat properti `ClientSize` dan `Size`.
- **View → Tab Order** untuk mengatur urutan pindah dengan tombol Tab.
- Isi `Items` ComboBox lewat Properties → `Items` (ketik satu per baris) atau smart tag.
- Smart tag (panah kecil di pojok kontrol) pada DataGridView → **Edit Columns**.
- Komponen tanpa tampilan (BindingSource, ErrorProvider) muncul di *component tray* di bawah form, bukan di atas form.

### Hacks mengerjakan lebih cepat

1. **Mulai dari yang bisa dipakai ulang:** `ModValidasi.vb` dari proyek sebelumnya masuk lewat **Add → Existing Item**.
2. **Tulis komentar sambil jalan**: satu baris di atas tiap Sub/Function (5% nilai ada di dokumentasi). Pakai kalimat pendek: `' Memeriksa semua isian sekaligus. True jika valid.`
3. **Salin tabel kontrol soal ke catatan** dan centang satu per satu saat membuat kontrol; nama kontrol yang beda dari tabel termasuk kesalahan.
4. **Kerjakan fitur wajib sampai selesai dulu.** Tantangan tambahan hanya untuk nilai lebih.
5. **Jalankan program setiap selesai satu fitur** (F5), jangan menumpuk sampai akhir; error kecil lebih mudah dilacak.
6. **Pesan error dari soal ditulis persis**, termasuk titik dan huruf kapital.
7. **Data awal sesuai syarat soal**: jumlah minimal, semua kategori terwakili, jumlah item dengan stok 0. Syarat ini dicek penguji.
8. **Uji kasus aneh**: kosong, spasi saja, huruf kecil, angka negatif, batas bawah dan atas (1 dan 14), tanda kutip `'`, kode ganda.
9. **Form harus terbuka di Designer tanpa error** sebelum zip. Buka tiap form sekali sebagai pemeriksaan terakhir.
10. **Salin Sub pola dari praktik repo** (yang sudah teruji) lalu ganti nama. Repo terbuka saat ujian, jadi pastikan kamu tahu persis **file dan bagian** mana yang akan dibuka: `pertemuan-07/praktik.md` (Try/Catch, ErrorProvider, ekspor), `pertemuan-08/praktik.md` (Array, List, DataTable, filter).

---

## Bagian 9: Checklist Akhir, Rubrik, dan Pengumpulan

### 9.1 Checklist teknis (centang sebelum zip)

- [ ] `Option Strict On` aktif di Project Properties **dan** ada di baris pertama tiap file.
- [ ] Nama semua kontrol sesuai tabel soal; tidak ada `Label1`, `Button1`, dan sejenisnya.
- [ ] Setiap TextBox/ComboBox punya Label keterangan berawalan `lbl`.
- [ ] `BindingSource` dan `ErrorProvider` dibuat di Designer; **tidak ada kontrol yang dibuat lewat kode**.
- [ ] Form terbuka di Designer **tanpa error**.
- [ ] Grid terikat lewat `BindingSource` (bukan `Rows.Add`) dan `DataSource` tidak diisi di Designer.
- [ ] `ValidasiInput()` memeriksa **semua** isian sekaligus, tanpa MessageBox untuk kesalahan validasi.
- [ ] Konversi angka memakai `TryParse` (bukan `Val`/`CInt`) bila diminta.
- [ ] Duplikat dicek (List atau loop `DataRow`), pesan persis sesuai soal.
- [ ] Teks pencarian diamankan (tanda kutip tidak membuat program error).
- [ ] `lblJumlah`/`lblTotal...` diperbarui di **dua tempat**: saat filter berubah dan saat data ditambah.
- [ ] `Try...Catch...Finally` dengan Catch yang diminta; `StreamWriter` ditutup di `Finally`.
- [ ] **Semua Sub dan Function punya komentar.**
- [ ] Hanya materi Pertemuan 1 sampai 8, tanpa database.

### 9.2 Rubrik penilaian (sama di Tugas 7 dan 8) **[REPO]**

| Kriteria | Bobot | Cara mengamankan nilainya |
|---|---|---|
| Kesesuaian fungsionalitas dengan spesifikasi | 25% | Centang setiap butir "Fitur wajib"; uji kasus khusus (kode ganda, pencarian kosong, tanda kutip, daftar kosong saat ekspor) |
| Struktur dan kualitas kode (penamaan, modularitas) | 20% | Nama kontrol sesuai tabel; validasi di `ValidasiInput`, filter di `TerapkanFilter`, dst.; form terbuka di Designer |
| Implementasi konsep VB sesuai materi | 20% | `TryParse`, `List(Of String)`, `DataTable`, `BindingSource`, filter `AND`, loop pada `DataRow`/`DataGridViewRow`, `Try...Catch...Finally` dua Catch |
| Interaksi data / komponen visual | 20% | Grid terikat lewat BindingSource, kolom rapi, data baru langsung tampil, label ringkasan tepat |
| Penanganan error dan validasi | 10% | Semua aturan lewat ErrorProvider, karakter khusus aman, program tidak pernah crash |
| Ketepatan waktu dan dokumentasi kode | 5% | Kumpulkan tepat waktu, format nama benar, kode berkomentar |

### 9.3 Cara mengumpulkan (ikuti perintah di soal ujian, ini pola dari tugas) **[REPO]**

1. **Tutup Visual Studio.**
2. Salin folder proyek, **hapus folder `bin` dan `obj`** (folder `.vs` yang tersembunyi juga boleh dibuang).
3. Zip dengan nama sesuai format soal. Pola tugas: `NIM_Nama_TugasXX.zip`, misalnya `241712052_VaidonShelloSinambela_Tugas08.zip`. Nama folder boleh mengandung spasi, tetapi nama zip harus sesuai format.
4. Screenshot sesuai daftar soal (Windows: `Win+Shift+S`). Gabungkan ke satu PDF (tempel di Word lalu Save As PDF, atau Print to PDF).
5. Upload di kelas.usu.ac.id **sebelum batas waktu** (cek tenggat di LMS, dan upload lebih awal dari batas).

Screenshot yang diminta di tugas sebelumnya, sebagai gambaran:
- **Tugas 7:** (1) ikon ErrorProvider di beberapa isian, (2) list berisi minimal tiga peminjaman, (3) MessageBox ekspor gagal karena file dibuka di Excel.
- **Tugas 8:** (1) grid setelah satu buku ditambah, (2) ErrorProvider kode ganda, (3) pencarian gabungan beserta `lblJumlah` dan `lblTotalStok`, (4) pencarian dengan tanda kutip tanpa error.

---

## Penutup: 12 Kalimat yang Wajib Diingat

1. Ganti `(Name)` **dulu**, baru double-click.
2. `Option Strict On`, jadi semua konversi ditulis eksplisit: `TryParse`, `Parse`, `.ToString()`, `CInt`.
3. Fungsi hidup di **Module**, Sub form hidup di **Class**.
4. Validasi = `errX.Clear()`, `valid = True`, deretan `If` berdiri sendiri, `Return valid`.
5. Batas rentang memakai `Not TryParse(...) OrElse x < a OrElse x > b`.
6. Kode berformat: huruf besar (`ToUpper`), cek panjang dulu, baru `StartsWith` dan `Substring`.
7. Data ke grid: **sumber data → BindingSource → DataGridView**, kolom diatur **setelah** `DataSource` terisi.
8. `List(Of T)` dicari dengan **loop**; `DataTable` dicari dengan **`bs.Filter`**.
9. Filter gabungan = kumpulkan syarat di `List(Of String)`, sambung `String.Join(" AND ", syarat)`.
10. **Selalu** amankan teks pengguna sebelum masuk ke `Filter` (tanda kutip digandakan).
11. File: `Try ... Catch IOException ... Finally penulis.Close()`, dengan `StreamWriter` dideklarasikan di luar `Try`.
12. Selesaikan fitur wajib, uji semua kasus, beri komentar, buka di Designer tanpa error, lalu zip tanpa `bin` dan `obj`.

Semoga ujianmu lancar.
