Imports System.Data.SqlClient
Public Class Login
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim chuoiketnoi As String = "workstation id=PS02140.mssql.somee.com;packet size=4096;user id=nguyentm;pwd=123456789;data source=PS02140.mssql.somee.com;persist security info=False;initial catalog=PS02140"
        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien where Manhanvien='" & txtuser.Text & "' and Password='" & txtpass.Text & "' ", KetNoi)
        Dim tb As New DataTable
        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Đăng Nhập Thành Công")
                Main.Show()
                Me.Hide()
            Else
                MessageBox.Show("Vui Lòng Đăng Nhập Lại Hoặc Liên hệ Admin")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        txtuser.Clear()
        txtpass.Clear()
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
