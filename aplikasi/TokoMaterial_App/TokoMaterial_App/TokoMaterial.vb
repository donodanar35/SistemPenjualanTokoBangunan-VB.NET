Imports MySql.Data.MySqlClient

Public Class TokoMaterial
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As New DataTable("satuan")
    Public ds As New DataSet
    Public DR As MySqlDataReader
    Public jabatan As String = Form1.jabatan
    Public username As String = Form1.username
    Public myName As String = Form1.nama

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Dim login As New Form1
        login.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub KonfigurasiUserToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KonfigurasiUserToolStripMenuItem1.Click
        Dim konf_user As New konf_user
        konf_user.ShowDialog()
    End Sub

    Private Sub KoneksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KoneksiToolStripMenuItem.Click
        Dim koneksi As New koneksi_konf
        koneksi.ShowDialog()
    End Sub

    Private Sub KaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KaryawanToolStripMenuItem.Click
        Dim karyawan As New karyawan
        karyawan.ShowDialog()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Dim customer As New Customer
        customer.ShowDialog()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        Dim supplier As New supplier
        supplier.ShowDialog()
    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        Dim barang As New barang
        barang.ShowDialog()
    End Sub

    Private Sub KategoriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KategoriToolStripMenuItem.Click
        Dim kategori As New Kategori
        kategori.ShowDialog()
    End Sub

    Private Sub SatuanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SatuanToolStripMenuItem.Click
        Dim satuan As New satuan
        satuan.ShowDialog()
    End Sub

    Private Sub HargaBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HargaBarangToolStripMenuItem.Click
        Dim harga_brg As New tent_harga
        harga_brg.ShowDialog()
    End Sub

    Private Sub TopSellingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TopSellingToolStripMenuItem.Click
        Dim preview As New Preview
        preview.printWhat = "top_item"
        preview.ShowDialog()
    End Sub

    Private Sub DaftarSupplierToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DaftarSupplierToolStripMenuItem1.Click
        Dim df_supplier As New Preview
        df_supplier.printWhat = "daftar suplier"
        df_supplier.ShowDialog()
    End Sub

    Private Sub DaftarCustomerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DaftarCustomerToolStripMenuItem1.Click
        Dim df_customer As New Preview
        df_customer.printWhat = "daftar customer"
        df_customer.ShowDialog()
    End Sub

    Private Sub TopSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TopSupplierToolStripMenuItem.Click
        Dim preview As New Preview
        preview.printWhat = "top_supplier"
        preview.ShowDialog()
    End Sub

    Private Sub TopCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TopCustomerToolStripMenuItem.Click
        Dim preview As New Preview
        preview.printWhat = "top_customer"
        preview.ShowDialog()
    End Sub

    Sub updatePromoNow()
        Dim trans_promo As New Transaksi_Promo
        Dim temp As Integer = trans_promo.CekPromo()
        If temp > 0 Then
            Dim result As Integer = MessageBox.Show("Anda yakin mau memperbarui promo sekarang?", "Perbarui Promo", MessageBoxButtons.YesNoCancel)
            LabelStatus.Text = "Anda mempunyai promo aktif!"
            If result = DialogResult.Cancel Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.No Then
            ElseIf result = DialogResult.Yes Then
                trans_promo.updatePromoNow()
                MessageBox.Show("Pembaruan promo berhasil!")
                LabelStatus.Text = "Pembaruan promo berhasil!"
            End If
        End If
        trans_promo.Dispose()
    End Sub

    Sub updateStockoutNow()
        Dim trans_stok As New Perbarui_Persediaan
        Dim temp As Integer = trans_stok.CekStockout
        If temp > 0 Then
            Dim result As Integer = MessageBox.Show("Anda mempunyai jadwal pengiriman barang, kirim sekarang?", "Perbarui Persediaan Keluar", MessageBoxButtons.YesNoCancel)
            LabelStatus.Text = "Anda mempunyai persediaan yang harus dikirim hari ini!"
            If result = DialogResult.Cancel Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.No Then
                LabelStatus.Text = "Anda mempunyai persediaan yang harus dikirim hari ini!"
            ElseIf result = DialogResult.Yes Then
                trans_stok.updateStockoutNow()
                'MessageBox.Show("Pembaruan persediaan keluar berhasil!")
                LabelStatus.Text = "Pembaruan persediaan keluar berhasil!"
            End If
        End If
        trans_stok.Dispose()
    End Sub

    Sub updateStockinNow()
        Dim trans_stok As New Perbarui_Persediaan
        Dim temp As Integer = trans_stok.CekStockin
        If temp > 0 Then
            Dim result As Integer = MessageBox.Show("Anda mempunyai jadwal penerimaan barang, terima sekarang?", "Perbarui Persediaan Masuk", MessageBoxButtons.YesNoCancel)
            LabelStatus.Text = "Anda mempunyai jadwal penerimaan barang hari ini!"
            If result = DialogResult.Cancel Then
                MessageBox.Show("Dibatalkan!")
            ElseIf result = DialogResult.No Then
                LabelStatus.Text = "Anda mempunyai jadwal penerimaan barang hari ini!"
            ElseIf result = DialogResult.Yes Then
                trans_stok.updateStockinNow()
                'MessageBox.Show("Pembaruan persediaan keluar berhasil!")
                LabelStatus.Text = "Pembaruan persediaan masuk berhasil!"
            End If
        End If
    End Sub

    Sub user_access()
        'konfigurasi
        KoneksiToolStripMenuItem.Visible = False
        LoginToolStripMenuItem.Visible = False
        KonfigurasiUserToolStripMenuItem1.Visible = False
        LoginToolStripMenuItem.Visible = False
        LogoutToolStripMenuItem.Visible = False
        'master
        CustomerToolStripMenuItem.Visible = False
        SupplierToolStripMenuItem.Visible = False
        KaryawanToolStripMenuItem.Visible = False
        BarangToolStripMenuItem.Visible = False
        KategoriToolStripMenuItem.Visible = False
        SatuanToolStripMenuItem.Visible = False
        HargaBarangToolStripMenuItem.Visible = False
        'transaksi
        SampelToolStripMenuItem.Visible = False
        FakturSampelToolStripMenuItem4.Visible = False
        TransaksiSampelToolStripMenuItem3.Visible = False
        PenjualanToolStripMenuItem.Visible = False
        FakturJualToolStripMenuItem3.Visible = False
        TransaksiJualToolStripMenuItem2.Visible = False
        PembelianToolStripMenuItem.Visible = False
        FakturBeliToolStripMenuItem2.Visible = False
        TransaksiBeliToolStripMenuItem1.Visible = False
        DiskonToolStripMenuItem.Visible = False
        FakturDiskonToolStripMenuItem1.Visible = False
        TransaksiDiskonToolStripMenuItem1.Visible = False
        StokToolStripMenuItem.Visible = False
        FakturPersediaanToolStripMenuItem.Visible = False
        TransaksiPersediaanToolStripMenuItem.Visible = False
        'laporan
        NotaSampelToolStripMenuItem.Visible = False
        NotaPenjualanToolStripMenuItem.Visible = False
        NotaPembelianToolStripMenuItem.Visible = False
        StokBarangToolStripMenuItem.Visible = False
        StokBarangToolStripMenuItem1.Visible = False
        MasukToolStripMenuItem.Visible = False
        KeluarToolStripMenuItem.Visible = False
        DiskonToolStripMenuItem2.Visible = False
        DaftarCustomerToolStripMenuItem.Visible = False
        DaftarCustomerToolStripMenuItem1.Visible = False
        TopCustomerToolStripMenuItem.Visible = False
        SupplierToolStripMenuItem.Visible = False
        TopSupplierToolStripMenuItem.Visible = False
        DaftarSupplierToolStripMenuItem1.Visible = False
        DaftarBarangToolStripMenuItem.Visible = False
        DaftarBarangToolStripMenuItem1.Visible = False
        TopSellingToolStripMenuItem.Visible = False

        If jabatan = "admin" Then
            'konfigurasi
            KoneksiToolStripMenuItem.Visible = True
            LoginToolStripMenuItem.Visible = True
            KonfigurasiUserToolStripMenuItem1.Visible = True
            LoginToolStripMenuItem.Visible = True
            LogoutToolStripMenuItem.Visible = True
            'master
            CustomerToolStripMenuItem.Visible = True
            SupplierToolStripMenuItem.Visible = True
            KaryawanToolStripMenuItem.Visible = True
            BarangToolStripMenuItem.Visible = True
            KategoriToolStripMenuItem.Visible = True
            SatuanToolStripMenuItem.Visible = True
            HargaBarangToolStripMenuItem.Visible = True
            'transaksi
            SampelToolStripMenuItem.Visible = True
            FakturSampelToolStripMenuItem4.Visible = True
            TransaksiSampelToolStripMenuItem3.Visible = True
            PenjualanToolStripMenuItem.Visible = True
            FakturJualToolStripMenuItem3.Visible = True
            TransaksiJualToolStripMenuItem2.Visible = True
            PembelianToolStripMenuItem.Visible = True
            FakturBeliToolStripMenuItem2.Visible = True
            TransaksiBeliToolStripMenuItem1.Visible = True
            DiskonToolStripMenuItem.Visible = True
            FakturDiskonToolStripMenuItem1.Visible = True
            TransaksiDiskonToolStripMenuItem1.Visible = True
            StokToolStripMenuItem.Visible = True
            FakturPersediaanToolStripMenuItem.Visible = True
            TransaksiPersediaanToolStripMenuItem.Visible = True
            'laporan
            NotaSampelToolStripMenuItem.Visible = True
            NotaPenjualanToolStripMenuItem.Visible = True
            NotaPembelianToolStripMenuItem.Visible = True
            StokBarangToolStripMenuItem.Visible = True
            StokBarangToolStripMenuItem1.Visible = True
            MasukToolStripMenuItem.Visible = True
            KeluarToolStripMenuItem.Visible = True
            DiskonToolStripMenuItem2.Visible = True
            DaftarCustomerToolStripMenuItem.Visible = True
            DaftarCustomerToolStripMenuItem1.Visible = True
            TopCustomerToolStripMenuItem.Visible = True
            SupplierToolStripMenuItem.Visible = True
            TopSupplierToolStripMenuItem.Visible = True
            DaftarSupplierToolStripMenuItem1.Visible = True
            DaftarBarangToolStripMenuItem.Visible = True
            DaftarBarangToolStripMenuItem1.Visible = True
            TopSellingToolStripMenuItem.Visible = True
        ElseIf jabatan = "manager" Then
            'konfigurasi
            LogoutToolStripMenuItem.Visible = True
            LoginToolStripMenuItem.Visible = True
            KonfigurasiUserToolStripMenuItem1.Visible = True
            LoginToolStripMenuItem.Visible = True
            'master
            CustomerToolStripMenuItem.Visible = True
            SupplierToolStripMenuItem.Visible = True
            KaryawanToolStripMenuItem.Visible = True
            BarangToolStripMenuItem.Visible = True
            KategoriToolStripMenuItem.Visible = True
            SatuanToolStripMenuItem.Visible = True
            HargaBarangToolStripMenuItem.Visible = True
            'transaksi
            PembelianToolStripMenuItem.Visible = True
            FakturBeliToolStripMenuItem2.Visible = True
            TransaksiBeliToolStripMenuItem1.Visible = True
            DiskonToolStripMenuItem.Visible = True
            FakturDiskonToolStripMenuItem1.Visible = True
            TransaksiDiskonToolStripMenuItem1.Visible = True
            'laporan
            NotaSampelToolStripMenuItem.Visible = True
            NotaPenjualanToolStripMenuItem.Visible = True
            NotaPembelianToolStripMenuItem.Visible = True
            StokBarangToolStripMenuItem.Visible = True
            StokBarangToolStripMenuItem1.Visible = True
            MasukToolStripMenuItem.Visible = True
            KeluarToolStripMenuItem.Visible = True
            DiskonToolStripMenuItem2.Visible = True
            DaftarCustomerToolStripMenuItem.Visible = True
            DaftarCustomerToolStripMenuItem1.Visible = True
            TopCustomerToolStripMenuItem.Visible = True
            SupplierToolStripMenuItem.Visible = True
            TopSupplierToolStripMenuItem.Visible = True
            DaftarSupplierToolStripMenuItem1.Visible = True
            DaftarBarangToolStripMenuItem.Visible = True
            DaftarBarangToolStripMenuItem1.Visible = True
            TopSellingToolStripMenuItem.Visible = True
            updatePromoNow()
        ElseIf jabatan = "kasir" Then
            'konfigurasi
            LoginToolStripMenuItem.Visible = True
            KonfigurasiUserToolStripMenuItem1.Visible = True
            LoginToolStripMenuItem.Visible = True
            LogoutToolStripMenuItem.Visible = True
            'master
            CustomerToolStripMenuItem.Visible = True
            BarangToolStripMenuItem.Visible = True
            'transaksi
            SampelToolStripMenuItem.Visible = True
            FakturSampelToolStripMenuItem4.Visible = True
            TransaksiSampelToolStripMenuItem3.Visible = True
            PenjualanToolStripMenuItem.Visible = True
            FakturJualToolStripMenuItem3.Visible = True
            TransaksiJualToolStripMenuItem2.Visible = True
            'laporan
            NotaSampelToolStripMenuItem.Visible = True
            NotaPenjualanToolStripMenuItem.Visible = True
            StokBarangToolStripMenuItem.Visible = True
            StokBarangToolStripMenuItem1.Visible = True
            DaftarSupplierToolStripMenuItem.Visible = False
            DiskonToolStripMenuItem2.Visible = True
            DaftarCustomerToolStripMenuItem.Visible = True
            DaftarCustomerToolStripMenuItem1.Visible = True
            TopCustomerToolStripMenuItem.Visible = True
            DaftarBarangToolStripMenuItem.Visible = True
            DaftarBarangToolStripMenuItem1.Visible = True
            TopSellingToolStripMenuItem.Visible = True
        ElseIf jabatan = "staf gudang" Then
            'konfigurasi
            LoginToolStripMenuItem.Visible = True
            KonfigurasiUserToolStripMenuItem1.Visible = True
            LoginToolStripMenuItem.Visible = True
            LogoutToolStripMenuItem.Visible = True
            'master
            SupplierToolStripMenuItem.Visible = True
            BarangToolStripMenuItem.Visible = True
            'transaksi
            StokToolStripMenuItem.Visible = True
            FakturPersediaanToolStripMenuItem.Visible = True
            TransaksiPersediaanToolStripMenuItem.Visible = True
            'laporan
            StokBarangToolStripMenuItem.Visible = True
            StokBarangToolStripMenuItem1.Visible = True
            MasukToolStripMenuItem.Visible = True
            KeluarToolStripMenuItem.Visible = True
            SupplierToolStripMenuItem.Visible = True
            TopSupplierToolStripMenuItem.Visible = True
            DaftarSupplierToolStripMenuItem1.Visible = True
            DaftarBarangToolStripMenuItem.Visible = True
            DaftarBarangToolStripMenuItem1.Visible = True
            updateStockoutNow()
            updateStockinNow()
        End If
    End Sub

    Private Sub TokoMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user_access()
        tampilUser()
    End Sub

    Private Sub FakturToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FakturDiskonToolStripMenuItem1.Click
        Dim diskon As New diskon
        diskon.ShowDialog()
    End Sub

    Private Sub FakturToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FakturPersediaanToolStripMenuItem.Click
        Dim stok As New stok
        stok.Show()
    End Sub

    Private Sub PerbaruiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiPersediaanToolStripMenuItem.Click
        Dim Pstok As New Perbarui_Persediaan
        Pstok.Show()
    End Sub

    Private Sub FakturToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles FakturSampelToolStripMenuItem4.Click
        Dim sampel As New sampel
        sampel.ShowDialog()
    End Sub

    Private Sub FakturToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles FakturJualToolStripMenuItem3.Click
        Dim penjualan As New Penjualan
        penjualan.ShowDialog()
    End Sub

    Private Sub FakturToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles FakturBeliToolStripMenuItem2.Click
        Dim pembelian As New pembelian
        pembelian.ShowDialog()
    End Sub

    Private Sub TransaksiToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles TransaksiSampelToolStripMenuItem3.Click
        Dim tSampel As New Transaksi_Sampel
        tSampel.ShowDialog()
    End Sub

    Private Sub TransaksiToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles TransaksiJualToolStripMenuItem2.Click
        Dim tJual As New Transaksi_Penjualan
        tJual.ShowDialog()
    End Sub

    Private Sub TransaksiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TransaksiBeliToolStripMenuItem1.Click
        Dim Tpembelian As New Transaksi_Pembelian
        Tpembelian.ShowDialog()
    End Sub

    Private Sub PerbaruiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TransaksiDiskonToolStripMenuItem1.Click
        Dim TPromo As New Transaksi_Promo
        TPromo.ShowDialog()
    End Sub

    Sub tampilUser()
        LinkLabelUsername.Text = myName
        LabelJabatan.Text = jabatan
    End Sub


    Private Sub LinkLabelUsername_Click(sender As Object, e As EventArgs) Handles LinkLabelUsername.Click
        Dim konf_user As New konf_user
        konf_user.ShowDialog()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Dispose()
    End Sub

    Private Sub NotaPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotaPenjualanToolStripMenuItem.Click
        Dim cetak As New Laporan
        cetak.printApa = "Penjualan Periodik"
        cetak.ShowDialog()
    End Sub

    Private Sub NotaPembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotaPembelianToolStripMenuItem.Click
        Dim cetak As New Laporan
        cetak.printApa = "Pembelian Periodik"
        cetak.ShowDialog()
    End Sub

    Private Sub DiskonToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DiskonToolStripMenuItem2.Click
        Dim cetak As New Laporan
        cetak.printApa = "Promo Aktual"
        cetak.ShowDialog()
    End Sub

    Private Sub NotaSampelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotaSampelToolStripMenuItem.Click
        Dim cetak As New Laporan
        cetak.printApa = "Sampel Periodik"
        cetak.ShowDialog()
    End Sub

    Private Sub StokBarangToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StokBarangToolStripMenuItem1.Click
        Dim cetak As New Preview
        cetak.printWhat = "Stok Barang"
        cetak.ShowDialog()
    End Sub

    Private Sub DaftarBarangToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DaftarBarangToolStripMenuItem1.Click
        Dim cetak As New Preview
        cetak.printWhat = "daftar barang"
        cetak.ShowDialog()
    End Sub

    Private Sub MasukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasukToolStripMenuItem.Click
        Dim cetak As New Laporan
        cetak.printApa = "Persediaan Masuk Periodik"
        cetak.ShowDialog()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim cetak As New Laporan
        cetak.printApa = "Persediaan Keluar Periodik"
        cetak.ShowDialog()
    End Sub
End Class