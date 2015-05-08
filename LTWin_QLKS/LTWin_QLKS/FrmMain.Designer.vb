<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TìmKiếmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐătPhòngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrợGiúpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhòngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KháchThuêPhòngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BáoCáoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThanhToánToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýToolStripMenuItem, Me.TìmKiếmToolStripMenuItem, Me.ĐătPhòngToolStripMenuItem, Me.TrợGiúpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(573, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QuảnLýToolStripMenuItem
        '
        Me.QuảnLýToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PhòngToolStripMenuItem, Me.KháchThuêPhòngToolStripMenuItem, Me.BáoCáoToolStripMenuItem, Me.ThanhToánToolStripMenuItem})
        Me.QuảnLýToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(68, 23)
        Me.QuảnLýToolStripMenuItem.Text = "Quản lý"
        '
        'TìmKiếmToolStripMenuItem
        '
        Me.TìmKiếmToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.TìmKiếmToolStripMenuItem.Name = "TìmKiếmToolStripMenuItem"
        Me.TìmKiếmToolStripMenuItem.Size = New System.Drawing.Size(81, 23)
        Me.TìmKiếmToolStripMenuItem.Text = "Tìm Kiếm"
        '
        'ĐătPhòngToolStripMenuItem
        '
        Me.ĐătPhòngToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ĐătPhòngToolStripMenuItem.Name = "ĐătPhòngToolStripMenuItem"
        Me.ĐătPhòngToolStripMenuItem.Size = New System.Drawing.Size(85, 23)
        Me.ĐătPhòngToolStripMenuItem.Text = "Đăt Phòng"
        '
        'TrợGiúpToolStripMenuItem
        '
        Me.TrợGiúpToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.TrợGiúpToolStripMenuItem.Name = "TrợGiúpToolStripMenuItem"
        Me.TrợGiúpToolStripMenuItem.Size = New System.Drawing.Size(75, 23)
        Me.TrợGiúpToolStripMenuItem.Text = "Trợ Giúp"
        '
        'PhòngToolStripMenuItem
        '
        Me.PhòngToolStripMenuItem.Name = "PhòngToolStripMenuItem"
        Me.PhòngToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.PhòngToolStripMenuItem.Text = "Phòng "
        '
        'KháchThuêPhòngToolStripMenuItem
        '
        Me.KháchThuêPhòngToolStripMenuItem.Name = "KháchThuêPhòngToolStripMenuItem"
        Me.KháchThuêPhòngToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.KháchThuêPhòngToolStripMenuItem.Text = "Khách Thuê Phòng"
        '
        'BáoCáoToolStripMenuItem
        '
        Me.BáoCáoToolStripMenuItem.Name = "BáoCáoToolStripMenuItem"
        Me.BáoCáoToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.BáoCáoToolStripMenuItem.Text = "Báo Cáo"
        '
        'ThanhToánToolStripMenuItem
        '
        Me.ThanhToánToolStripMenuItem.Name = "ThanhToánToolStripMenuItem"
        Me.ThanhToánToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.ThanhToánToolStripMenuItem.Text = "Thanh Toán"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 362)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMain"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents QuảnLýToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TìmKiếmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ĐătPhòngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrợGiúpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PhòngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KháchThuêPhòngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BáoCáoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThanhToánToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
