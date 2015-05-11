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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.QuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhòngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KháchThuêPhòngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BáoCáoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThanhToánToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TìmKiếmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhòngToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐặttPhòngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrợGiúpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýToolStripMenuItem, Me.TìmKiếmToolStripMenuItem, Me.ĐặttPhòngToolStripMenuItem, Me.TrợGiúpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(723, 55)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QuảnLýToolStripMenuItem
        '
        Me.QuảnLýToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QuảnLýToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PhòngToolStripMenuItem, Me.KháchThuêPhòngToolStripMenuItem, Me.BáoCáoToolStripMenuItem, Me.ThanhToánToolStripMenuItem})
        Me.QuảnLýToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.QuảnLýToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.QuảnLýToolStripMenuItem.Image = CType(resources.GetObject("QuảnLýToolStripMenuItem.Image"), System.Drawing.Image)
        Me.QuảnLýToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.QuảnLýToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(87, 51)
        Me.QuảnLýToolStripMenuItem.Text = "Quản lý"
        Me.QuảnLýToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PhòngToolStripMenuItem
        '
        Me.PhòngToolStripMenuItem.Name = "PhòngToolStripMenuItem"
        Me.PhòngToolStripMenuItem.Size = New System.Drawing.Size(238, 28)
        Me.PhòngToolStripMenuItem.Text = "Phòng "
        '
        'KháchThuêPhòngToolStripMenuItem
        '
        Me.KháchThuêPhòngToolStripMenuItem.Name = "KháchThuêPhòngToolStripMenuItem"
        Me.KháchThuêPhòngToolStripMenuItem.Size = New System.Drawing.Size(238, 28)
        Me.KháchThuêPhòngToolStripMenuItem.Text = "Khách Thuê Phòng"
        '
        'BáoCáoToolStripMenuItem
        '
        Me.BáoCáoToolStripMenuItem.Name = "BáoCáoToolStripMenuItem"
        Me.BáoCáoToolStripMenuItem.Size = New System.Drawing.Size(238, 28)
        Me.BáoCáoToolStripMenuItem.Text = "Báo Cáo"
        '
        'ThanhToánToolStripMenuItem
        '
        Me.ThanhToánToolStripMenuItem.Name = "ThanhToánToolStripMenuItem"
        Me.ThanhToánToolStripMenuItem.Size = New System.Drawing.Size(238, 28)
        Me.ThanhToánToolStripMenuItem.Text = "Thanh Toán"
        '
        'TìmKiếmToolStripMenuItem
        '
        Me.TìmKiếmToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TìmKiếmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PhòngToolStripMenuItem1, Me.KháchHàngToolStripMenuItem})
        Me.TìmKiếmToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.TìmKiếmToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TìmKiếmToolStripMenuItem.Image = CType(resources.GetObject("TìmKiếmToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TìmKiếmToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TìmKiếmToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TìmKiếmToolStripMenuItem.Name = "TìmKiếmToolStripMenuItem"
        Me.TìmKiếmToolStripMenuItem.Size = New System.Drawing.Size(107, 51)
        Me.TìmKiếmToolStripMenuItem.Text = "Tìm Kiếm"
        Me.TìmKiếmToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PhòngToolStripMenuItem1
        '
        Me.PhòngToolStripMenuItem1.Name = "PhòngToolStripMenuItem1"
        Me.PhòngToolStripMenuItem1.Size = New System.Drawing.Size(182, 28)
        Me.PhòngToolStripMenuItem1.Text = "Phòng"
        '
        'KháchHàngToolStripMenuItem
        '
        Me.KháchHàngToolStripMenuItem.Name = "KháchHàngToolStripMenuItem"
        Me.KháchHàngToolStripMenuItem.Size = New System.Drawing.Size(182, 28)
        Me.KháchHàngToolStripMenuItem.Text = "Khách Hàng"
        '
        'ĐặttPhòngToolStripMenuItem
        '
        Me.ĐặttPhòngToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ĐặttPhòngToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ĐặttPhòngToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ĐặttPhòngToolStripMenuItem.Image = CType(resources.GetObject("ĐặttPhòngToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ĐặttPhòngToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ĐặttPhòngToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ĐặttPhòngToolStripMenuItem.Name = "ĐặttPhòngToolStripMenuItem"
        Me.ĐặttPhòngToolStripMenuItem.Size = New System.Drawing.Size(110, 51)
        Me.ĐặttPhòngToolStripMenuItem.Text = "Đặt Phòng"
        Me.ĐặttPhòngToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TrợGiúpToolStripMenuItem
        '
        Me.TrợGiúpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TrợGiúpToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.TrợGiúpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TrợGiúpToolStripMenuItem.Image = CType(resources.GetObject("TrợGiúpToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TrợGiúpToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TrợGiúpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TrợGiúpToolStripMenuItem.Name = "TrợGiúpToolStripMenuItem"
        Me.TrợGiúpToolStripMenuItem.Size = New System.Drawing.Size(98, 51)
        Me.TrợGiúpToolStripMenuItem.Text = "Trợ Giúp"
        Me.TrợGiúpToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 55)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(723, 333)
        Me.DataGridView1.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 366)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(723, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 388)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMain"
        Me.Text = "Quản Lý Khách Sạn"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents QuảnLýToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TìmKiếmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ĐặttPhòngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrợGiúpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PhòngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KháchThuêPhòngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BáoCáoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThanhToánToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PhòngToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel

End Class
