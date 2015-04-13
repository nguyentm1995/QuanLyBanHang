Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class KhachHang
    Dim tb As New DataTable
    Dim tb1 As New DataTable
    Dim connectstr As String = "workstation id=PS02140.mssql.somee.com;packet size=4096;user id=nguyentm;pwd=123456789;data source=PS02140.mssql.somee.com;persist security info=False;initial catalog=PS02140"
    Dim KetNoi As New SqlConnection(connectstr)
    Private Sub loaddata()
        Dim Ketnoi As New SqlConnection(connectstr)
        Dim sqladapter As New SqlDataAdapter("select * from KhachHang", Ketnoi)
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
    Private Sub khachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Ketnoi As New SqlConnection(connectstr)
        Dim sqladapter As New SqlDataAdapter("select * from KhachHang", Ketnoi)
        Try
            sqladapter.Fill(tb)
        Catch ex As Exception
        End Try
        DataGridView.DataSource = tb
        Ketnoi.Close()
    End Sub
    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim deletehd As String = "delete from HoaDon where KhachHang_MaKH = @MaKH"
        Dim com1 As New SqlCommand(deletehd, KetNoi)
        Try
            com1.Parameters.AddWithValue("@MaKH", Me.txtmakh.Text)
            com1.ExecuteNonQuery()
            KetNoi.Close()
        Catch ex As Exception
        End Try
        tb1.Clear()
        SanPham.DataGridView.DataSource = tb1
        SanPham.DataGridView.DataSource = Nothing
        loaddatahd()

        KetNoi.Open()
        Dim delete As String = "delete from KhachHang where MaKH = @MaKH"
        Dim com As New SqlCommand(delete, KetNoi)
        Try
            com.Parameters.AddWithValue("@MaKH", Me.txtmakh.Text)
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
        txtmakh.Text = DataGridView.Item(0, index).Value
        txttenkh.Text = DataGridView.Item(1, index).Value
        txtsdt.Text = DataGridView.Item(2, index).Value
        txtdiachi.Text = DataGridView.Item(3, index).Value
        txtmatkhau.Text = DataGridView.Item(4, index).Value
    End Sub
    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Dim connectstr As String = "workstation id=PS02140.mssql.somee.com;packet size=4096;user id=nguyentm;pwd=123456789;data source=PS02140.mssql.somee.com;persist security info=False;initial catalog=PS02140"
        Dim KetNoi As New SqlConnection(connectstr)
        KetNoi.Open()
        Dim add As String = "INSERT INTO KhachHang VALUES (@Makh,@Tenkh,@Sodt,@diachi,@Password)"
        Dim index As SqlCommand = New SqlCommand(add, KetNoi)
        index.Parameters.AddWithValue("@Makh", txtmakh.Text)
        index.Parameters.AddWithValue("@Tenkh", txttenkh.Text)
        index.Parameters.AddWithValue("@Sodt", txtsdt.Text)
        index.Parameters.AddWithValue("@DiaChi", txtdiachi.Text)
        index.Parameters.AddWithValue("@Password", txtmatkhau.Text)
        index.ExecuteNonQuery()
        KetNoi.Close()
        MessageBox.Show("Kết Nối Thành Công")
    End Sub
    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim KetNoi As New SqlConnection(connectstr)
        KetNoi.Open()
        Dim edit As String = "UPDATE KhachHang where  SET TenKH = @TenKH, SoDT = @SoDT, DiaChi = @DiaChi, Password = @PassWord Where MaKH = @MaKH"
        Dim com As New SqlCommand(edit, KetNoi)
        Try
            com.Parameters.AddWithValue("@MaKH", txtmakh.Text)
            com.Parameters.AddWithValue("@TenKH", txttenkh.Text)
            com.Parameters.AddWithValue("@SoDT", txtsdt.Text)
            com.Parameters.AddWithValue("@DiaChi", txtdiachi.Text)
            com.Parameters.AddWithValue("@Password", txtmatkhau.Text)
            com.ExecuteNonQuery()
            KetNoi.Close()
            MessageBox.Show("Kết Nối Thành Công")
        Catch ex As Exception
            MessageBox.Show("Từ Chối Truy Cập")
        End Try
        tb.Clear()
        DataGridView.DataSource = tb
        DataGridView.DataSource = Nothing
        loaddata()
    End Sub
    Private Sub btntai_Click(sender As Object, e As EventArgs) Handles btntai.Click
        Dim Ketnoi As New SqlConnection(connectstr)
        Dim sqladapter As New SqlDataAdapter("select * from KhachHang", Ketnoi)
        Try
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
        NhanVien.Show()
        Me.Hide()

    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Close()

    End Sub

    Private Sub SảnPhẩmToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem1.Click
        SanPham.Show()
        Me.Hide()

    End Sub
End Class