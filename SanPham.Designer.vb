﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SanPham
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtmasp = New System.Windows.Forms.TextBox()
        Me.txtchitietsp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsoluongsp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdongiasp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttensp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThôngTinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NhânViênToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThôngTinToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SảnPhẩmToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView
        '
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(13, 269)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(613, 154)
        Me.DataGridView.TabIndex = 23
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(493, 227)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(99, 35)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "s"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(455, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(171, 183)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sử Dụng"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(38, 138)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(99, 35)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Tải"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(38, 98)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 35)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Xoá"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(38, 59)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 35)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Sửa"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(38, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 35)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Thêm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtmasp)
        Me.GroupBox1.Controls.Add(Me.txtchitietsp)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtsoluongsp)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtdongiasp)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txttensp)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 217)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Quản Lý"
        '
        'txtmasp
        '
        Me.txtmasp.Location = New System.Drawing.Point(183, 25)
        Me.txtmasp.Name = "txtmasp"
        Me.txtmasp.Size = New System.Drawing.Size(200, 26)
        Me.txtmasp.TabIndex = 6
        '
        'txtchitietsp
        '
        Me.txtchitietsp.Location = New System.Drawing.Point(183, 176)
        Me.txtchitietsp.Name = "txtchitietsp"
        Me.txtchitietsp.Size = New System.Drawing.Size(200, 26)
        Me.txtchitietsp.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Sản Phẩm :"
        '
        'txtsoluongsp
        '
        Me.txtsoluongsp.Location = New System.Drawing.Point(183, 138)
        Me.txtsoluongsp.Name = "txtsoluongsp"
        Me.txtsoluongsp.Size = New System.Drawing.Size(200, 26)
        Me.txtsoluongsp.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên Sản Phẩm :"
        '
        'txtdongiasp
        '
        Me.txtdongiasp.Location = New System.Drawing.Point(183, 98)
        Me.txtdongiasp.Name = "txtdongiasp"
        Me.txtdongiasp.Size = New System.Drawing.Size(200, 26)
        Me.txtdongiasp.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Đơn Giá Sản Phẩm :"
        '
        'txttensp
        '
        Me.txttensp.Location = New System.Drawing.Point(183, 63)
        Me.txttensp.Name = "txttensp"
        Me.txttensp.Size = New System.Drawing.Size(200, 26)
        Me.txttensp.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Số Lượng Sản Phẩm :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Chi Tiết Sản Phẩm :"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýToolStripMenuItem, Me.ThôngTinToolStripMenuItem, Me.ThôngTinToolStripMenuItem1, Me.ThoátToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(637, 29)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QuảnLýToolStripMenuItem
        '
        Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(68, 25)
        Me.QuảnLýToolStripMenuItem.Text = "Home"
        '
        'ThôngTinToolStripMenuItem
        '
        Me.ThôngTinToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SảnPhẩmToolStripMenuItem, Me.NhânViênToolStripMenuItem1})
        Me.ThôngTinToolStripMenuItem.Name = "ThôngTinToolStripMenuItem"
        Me.ThôngTinToolStripMenuItem.Size = New System.Drawing.Size(84, 25)
        Me.ThôngTinToolStripMenuItem.Text = "Quản Lý"
        '
        'SảnPhẩmToolStripMenuItem
        '
        Me.SảnPhẩmToolStripMenuItem.Name = "SảnPhẩmToolStripMenuItem"
        Me.SảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.SảnPhẩmToolStripMenuItem.Text = "Khách Hàng"
        '
        'NhânViênToolStripMenuItem1
        '
        Me.NhânViênToolStripMenuItem1.Name = "NhânViênToolStripMenuItem1"
        Me.NhânViênToolStripMenuItem1.Size = New System.Drawing.Size(172, 26)
        Me.NhânViênToolStripMenuItem1.Text = "Nhân Viên"
        '
        'ThôngTinToolStripMenuItem1
        '
        Me.ThôngTinToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SảnPhẩmToolStripMenuItem1})
        Me.ThôngTinToolStripMenuItem1.Name = "ThôngTinToolStripMenuItem1"
        Me.ThôngTinToolStripMenuItem1.Size = New System.Drawing.Size(99, 25)
        Me.ThôngTinToolStripMenuItem1.Text = "Thông Tin"
        '
        'SảnPhẩmToolStripMenuItem1
        '
        Me.SảnPhẩmToolStripMenuItem1.Name = "SảnPhẩmToolStripMenuItem1"
        Me.SảnPhẩmToolStripMenuItem1.Size = New System.Drawing.Size(156, 26)
        Me.SảnPhẩmToolStripMenuItem1.Text = "Sản Phẩm"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(66, 25)
        Me.ThoátToolStripMenuItem.Text = "Thoát"
        '
        'SanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(637, 429)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "SanPham"
        Me.Text = "SanPham"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtmasp As System.Windows.Forms.TextBox
    Friend WithEvents txtchitietsp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsoluongsp As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdongiasp As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttensp As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents QuảnLýToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThôngTinToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThôngTinToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SảnPhẩmToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NhânViênToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
