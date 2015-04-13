Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class SanPham
    Dim tb As New DataTable
    Dim tb1 As New DataTable
    Dim connectstr As String = "workstation id=PS02140.mssql.somee.com;packet size=4096;user id=nguyentm;pwd=123456789;data source=PS02140.mssql.somee.com;persist security info=False;initial catalog=PS02140"
    Dim KetNoi As New SqlConnection(connectstr)
    Private Sub loaddata()
        Dim Ketnoi As New SqlConnection(connectstr)
        Dim sqladapter As New SqlDataAdapter("select * from SanPham", Ketnoi)
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
        Me.DataGridView.DataSource = tb1
        Ketnoi.Close()
    End Sub

    Private Sub SanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Ketnoi As New SqlConnection(connectstr)
        Dim sqladapter As New SqlDataAdapter("select * from SanPham", Ketnoi)
        Try
            sqladapter.Fill(tb)
        Catch ex As Exception
        End Try
        DataGridView.DataSource = tb
        Ketnoi.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim deletehd As String = "delete from HoaDon where SanPham_MaSP = @MaSP"
        Dim com1 As New SqlCommand(deletehd, KetNoi)
        Try
            com1.Parameters.AddWithValue("@MaSP", Me.txtmasp.Text)
            com1.ExecuteNonQuery()
            KetNoi.Close()
        Catch ex As Exception
        End Try
        tb1.Clear()
        Me.DataGridView.DataSource = tb1
        Me.DataGridView.DataSource = Nothing
        loaddatahd()
        KetNoi.Open()
        Dim delete As String = "delete from SanPham where MaSP = @MaSP"
        Dim com As New SqlCommand(delete, KetNoi)
        Try
            com.Parameters.AddWithValue("@MaSP", Me.txtmasp.Text)
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
        txtmasp.Text = DataGridView.Item(0, index).Value
        txttensp.Text = DataGridView.Item(1, index).Value
        txtdongiasp.Text = DataGridView.Item(2, index).Value
        txtsoluongsp.Text = DataGridView.Item(3, index).Value
        txtchitietsp.Text = DataGridView.Item(4, index).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectstr As String = "workstation id=PS02140.mssql.somee.com;packet size=4096;user id=nguyentm;pwd=123456789;data source=PS02140.mssql.somee.com;persist security info=False;initial catalog=PS02140"
        Dim KetNoi As New SqlConnection(connectstr)
        KetNoi.Open()
        Dim add As String = "INSERT INTO SanPham VALUES (@Masp,@Tensp,@Dongiasp,@Soluongsp,@Chitietsp)"
        Dim index As SqlCommand = New SqlCommand(add, KetNoi)
        index.Parameters.AddWithValue("@Masp", txtmasp.Text)
        index.Parameters.AddWithValue("@Tensp", txttensp.Text)
        index.Parameters.AddWithValue("@Dongiasp", txtdongiasp.Text)
        index.Parameters.AddWithValue("@Soluongsp", txtsoluongsp.Text)
        index.Parameters.AddWithValue("@Chitietsp", txtchitietsp.Text)
        index.ExecuteNonQuery()
        KetNoi.Close()
        MessageBox.Show("Kết Nối Thành Công")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim KetNoi As New SqlConnection(connectstr)
        KetNoi.Open()
        Dim edit As String = "UPDATE SanPham where  SET Tensp = @Tensp, Dongiasp = @Dongiasp, Soluongsp = @Soluongsp, Chitietsp = @Chitietsp Where Masp = @Masp"
        Dim com As New SqlCommand(edit, KetNoi)
        Try
            com.Parameters.AddWithValue("@Masp", txtmasp.Text)
            com.Parameters.AddWithValue("@Tensp", txttensp.Text)
            com.Parameters.AddWithValue("@Dongiasp", txtdongiasp.Text)
            com.Parameters.AddWithValue("@Soluongsp", txtsoluongsp.Text)
            com.Parameters.AddWithValue("@Chitietsp", txtchitietsp.Text)
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Ketnoi As New SqlConnection(connectstr)
        Dim sqladapter As New SqlDataAdapter("select * from SanPham", Ketnoi)
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
        KhachHang.Show()
        Me.Hide()

    End Sub

    Private Sub NhânViênToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NhânViênToolStripMenuItem1.Click
        NhanVien.Show()
        Me.Hide()

    End Sub

    Private Sub SảnPhẩmToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem1.Click

    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()

    End Sub
End Class