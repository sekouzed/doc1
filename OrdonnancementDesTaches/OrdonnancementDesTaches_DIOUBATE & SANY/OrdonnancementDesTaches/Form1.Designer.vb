<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pb_schemas = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lb_note = New System.Windows.Forms.ListBox()
        Me.lb_listeDesTaches = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AjouterMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnleverMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NettoyerMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.cb_algo = New System.Windows.Forms.ToolStripComboBox()
        Me.cb_zoom = New System.Windows.Forms.ToolStripComboBox()
        Me.TRACERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pb_schemas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.BackgroundImage = CType(resources.GetObject("TableLayoutPanel2.BackgroundImage"), System.Drawing.Image)
        Me.TableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.MenuStrip2, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(962, 578)
        Me.TableLayoutPanel2.TabIndex = 15
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(11, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(940, 530)
        Me.Panel3.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.pb_schemas)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(246, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(694, 513)
        Me.Panel1.TabIndex = 18
        '
        'pb_schemas
        '
        Me.pb_schemas.BackColor = System.Drawing.Color.White
        Me.pb_schemas.Location = New System.Drawing.Point(6, 3)
        Me.pb_schemas.Name = "pb_schemas"
        Me.pb_schemas.Size = New System.Drawing.Size(494, 288)
        Me.pb_schemas.TabIndex = 17
        Me.pb_schemas.TabStop = False
        Me.pb_schemas.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(246, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "...."
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lb_note)
        Me.Panel4.Controls.Add(Me.lb_listeDesTaches)
        Me.Panel4.Controls.Add(Me.MenuStrip1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(246, 530)
        Me.Panel4.TabIndex = 18
        '
        'lb_note
        '
        Me.lb_note.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lb_note.FormattingEnabled = True
        Me.lb_note.Location = New System.Drawing.Point(0, 191)
        Me.lb_note.Name = "lb_note"
        Me.lb_note.Size = New System.Drawing.Size(246, 339)
        Me.lb_note.TabIndex = 15
        '
        'lb_listeDesTaches
        '
        Me.lb_listeDesTaches.BackColor = System.Drawing.Color.White
        Me.lb_listeDesTaches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_listeDesTaches.Dock = System.Windows.Forms.DockStyle.Top
        Me.lb_listeDesTaches.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lb_listeDesTaches.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lb_listeDesTaches.FormattingEnabled = True
        Me.lb_listeDesTaches.ItemHeight = 15
        Me.lb_listeDesTaches.Items.AddRange(New Object() {"Liste des taches"})
        Me.lb_listeDesTaches.Location = New System.Drawing.Point(0, 24)
        Me.lb_listeDesTaches.Name = "lb_listeDesTaches"
        Me.lb_listeDesTaches.Size = New System.Drawing.Size(246, 167)
        Me.lb_listeDesTaches.TabIndex = 13
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterMenu, Me.EnleverMenu, Me.NettoyerMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(246, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AjouterMenu
        '
        Me.AjouterMenu.Image = CType(resources.GetObject("AjouterMenu.Image"), System.Drawing.Image)
        Me.AjouterMenu.Name = "AjouterMenu"
        Me.AjouterMenu.Size = New System.Drawing.Size(72, 20)
        Me.AjouterMenu.Text = "ajouter"
        '
        'EnleverMenu
        '
        Me.EnleverMenu.Image = CType(resources.GetObject("EnleverMenu.Image"), System.Drawing.Image)
        Me.EnleverMenu.Name = "EnleverMenu"
        Me.EnleverMenu.Size = New System.Drawing.Size(73, 20)
        Me.EnleverMenu.Text = "enlever"
        '
        'NettoyerMenu
        '
        Me.NettoyerMenu.Image = CType(resources.GetObject("NettoyerMenu.Image"), System.Drawing.Image)
        Me.NettoyerMenu.Name = "NettoyerMenu"
        Me.NettoyerMenu.Size = New System.Drawing.Size(79, 20)
        Me.NettoyerMenu.Text = "nettoyer"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip2.BackgroundImage = CType(resources.GetObject("MenuStrip2.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip2.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cb_algo, Me.cb_zoom, Me.TRACERToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(8, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(946, 34)
        Me.MenuStrip2.TabIndex = 15
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'cb_algo
        '
        Me.cb_algo.BackColor = System.Drawing.SystemColors.Menu
        Me.cb_algo.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.cb_algo.Items.AddRange(New Object() {"Rate Monotonic ( RM )", "Inverse Deadline ( ID )", "Earliest Deadline ( ED )", "Least Laxity ( LL)"})
        Me.cb_algo.Name = "cb_algo"
        Me.cb_algo.Size = New System.Drawing.Size(240, 30)
        '
        'cb_zoom
        '
        Me.cb_zoom.BackColor = System.Drawing.SystemColors.Menu
        Me.cb_zoom.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.cb_zoom.Items.AddRange(New Object() {"Petite echelle ", "Moyenne echelle ", "Grande echelle "})
        Me.cb_zoom.Name = "cb_zoom"
        Me.cb_zoom.Size = New System.Drawing.Size(150, 30)
        '
        'TRACERToolStripMenuItem
        '
        Me.TRACERToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.TRACERToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TRACERToolStripMenuItem.Font = New System.Drawing.Font("Copperplate Gothic Light", 9.0!)
        Me.TRACERToolStripMenuItem.Image = CType(resources.GetObject("TRACERToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TRACERToolStripMenuItem.Name = "TRACERToolStripMenuItem"
        Me.TRACERToolStripMenuItem.Size = New System.Drawing.Size(87, 30)
        Me.TRACERToolStripMenuItem.Text = "TRACER"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(962, 578)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordonnancement de tâches par DIOUBATE SEKOU"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb_schemas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents cb_algo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cb_zoom As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents TRACERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents lb_listeDesTaches As System.Windows.Forms.ListBox
    Friend WithEvents pb_schemas As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lb_note As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AjouterMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnleverMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NettoyerMenu As System.Windows.Forms.ToolStripMenuItem

End Class
