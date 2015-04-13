Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class NhanVien
    Dim tb As New DataTable
    Dim tb1 As New DataTable
    Dim connectstr As String = "workstation id=PS02140.mssql.somee.com;packet size=4096;user id=nguyentm;pwd=123456789;data source=PS02140.mssql.somee.com;persist security info=False;initial catalog=PS02140"
    Dim KetNoi As New SqlConnection(connectstr)
    Private Sub loaddata()
        Dim Ketnoi As New SqlConnection(connectstr)
        Dim sqladapter As New SqlDataAdapter("select * from Nhanvien", Ketnoi)
        Try
            Ketnoi.Open()
            sqladapter.Fill(tb)
        Catch ex As Exception
        End Try
        DataGridView.DataSource = tb
        Ketnoi.Close()
    End Sub
    Private Sub loaddatahd()
        Dim Ketnoi As New SqlConnection(connectstr)
        Dim sqladapter As New SqlDataAdapter("select * from HoaDon", Ketnoi)
        Try
            Ketnoi.Open()
            sqladapter.Fill(tb1)
        Catch ex As Exception
        End Try
        SanPham.DataGridView.DataSource = tb1
        Ketnoi.Close()
    End Sub

    Private Sub NhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Ketnoi As New SqlConnection(connectstr)
        Dim sqladapter As New SqlDataAdapter("select * from NhanVien", Ketnoi)
        Try
            sqladapter.Fill(tb)
        Catch ex As Exception
        End Try
        DataGridView.DataSource = tb
        Ketnoi.Close()
    End Sub


    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim deletehd As String = "delete from HoaDon where NhanVien_MaKH = @Manhanvien"
        Dim com1 As New SqlCommand(deletehd, KetNoi)
        Try
            com1.Parameters.AddWithValue("@Manhanvien", Me.txtmanhanvien.Text)
            com1.ExecuteNonQuery()
            KetNoi.Close()
        Catch ex As Exception
        End Try
        tb1.Clear()
        SanPham.DataGridView.DataSource = tb1
        SanPham.DataGridView.DataSource = Nothing
        loaddatahd()

        KetNoi.Open()
        Dim delete As String = "delete from NhanVien where Manhanvien = @Manhanvien"
        Dim com As New SqlCommand(delete, KetNoi)
        Try
            com.Parameters.AddWithValue("@Manhanvien", Me.txtmanhanvien.Text)
            com.ExecuteNonQuery()
            KetNoi.Close()
        Catch ex As Exception
            MessageBox.Show("Từ Chối Truy Cập")
        End Try
        tb.Clear()
        DataGridView.DataSource = tb
        DataGridView.DataSource = Nothing
        loaddata()
    End Sub
    Private Sub DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellContentClick
        Dim index As Integer = DataGridView.CurrentCell.RowIndex
        txtmanhanvien.Text = DataGridView.Item(0, index).Value
        txttennhanvien.Text = DataGridView.Item(1, index).Value
        txtsodienthoai.Text = DataGridView.Item(2, index).Value
        txtdiachi.Text = DataGridView.Item(3, index).Value
        txtpassword.Text = DataGridView.Item(4, index).Value
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim connectstr As String = "workstation id=PS02140.mssql.somee.com;packet size=4096;user id=nguyentm;pwd=123456789;data source=PS02140.mssql.somee.com;persist security info=False;initial catalog=PS02140"
        Dim KetNoi As New SqlConnection(connectstr)

        KetNoi.Open()
        Dim add As String = "INSERT INTO NhanVien VALUES (@Manhanvien, @Tennhanvien, @sodienthoai, @diachi, @password)"
        Dim index As SqlCommand = New SqlCommand(add, KetNoi)
        index.Parameters.AddWithValue("@Manhanvien", txtmanhanvien.Text)
        index.Parameters.AddWithValue("@Tennhanvien", txttennhanvien.Text)
        index.Parameters.AddWithValue("@sodienthoai", txtsodienthoai.Text)
        index.Parameters.AddWithValue("@DiaChi", txtdiachi.Text)
        index.Parameters.AddWithValue("@Password", txtpassword.Text)
        index.ExecuteNonQuery()
        KetNoi.Close()
        MessageBox.Show("Kết Nối Thành Công")
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim KetNoi As New SqlConnection(connectstr)
        KetNoi.Open()
        Dim edit As String = "UPDATE NhanVien SET Manhanvien = @Manhanvien, Tennhanvien = @Tennhanvien, Sodienthoai = @sodienthoai, DiaChi = @DiaChi, Password = @PassWord"
        Dim com As New SqlCommand(edit, KetNoi)
        Try
            com.Parameters.AddWithValue("@Manhanvien", txtmanhanvien.Text)
            com.Parameters.AddWithValue("@Tennhanvien", txttennhanvien.Text)
            com.Parameters.AddWithValue("@sodienthoai", txtsodienthoai.Text)
            com.Parameters.AddWithValue("@DiaChi", txtdiachi.Text)
            com.Parameters.AddWithValue("@Password", txtpassword.Text)
            com.ExecuteNonQuery()
            KetNoi.Close()
            MessageBox.Show("Kết Nối Thành Công")
        Catch ex As Exception
            MessageBox.Show("Kết Nối Thất Bại")
        End Try
        tb.Clear()
        DataGridView.DataSource = tb
        DataGridView.DataSource = Nothing
        loaddata()
    End Sub

    Private Sub btntai_Click(sender As Object, e As EventArgs) Handles btntai.Click
        Dim Ketnoi As New SqlConnection(connectstr)
        Dim sqladapter As New SqlDataAdapter("select * from Nhanvien", Ketnoi)
        Try
            Ketnoi.Open()
            sqladapter.Fill(tb)
        Catch ex As Exception
        End Try
        DataGridView.DataSource = tb
        Ketnoi.Close()
    End Sub

    Private Sub QuảnLýToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýToolStripMenuItem.Click
        Main.Show()
        Me.Hide()

    End Sub

    Private Sub SảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem.Click
        KhachHang.Show()
        Me.Hide()

    End Sub

    Private Sub SảnPhẩmToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem1.Click
        SanPham.Show()
        Me.Hide()

    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Close()

    End Sub
End Class