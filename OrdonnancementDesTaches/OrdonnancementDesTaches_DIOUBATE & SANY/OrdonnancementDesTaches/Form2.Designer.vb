<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.bt_ajouter = New System.Windows.Forms.Button()
        Me.tb_c = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_d = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_r = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_p = New System.Windows.Forms.TextBox()
        Me.bt_terminer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bt_ajouter
        '
        Me.bt_ajouter.BackColor = System.Drawing.Color.Transparent
        Me.bt_ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_ajouter.Font = New System.Drawing.Font("Copperplate Gothic Light", 10.0!)
        Me.bt_ajouter.Location = New System.Drawing.Point(293, 77)
        Me.bt_ajouter.Name = "bt_ajouter"
        Me.bt_ajouter.Size = New System.Drawing.Size(117, 68)
        Me.bt_ajouter.TabIndex = 40
        Me.bt_ajouter.Text = "Ajouter"
        Me.bt_ajouter.UseVisualStyleBackColor = False
        '
        'tb_c
        '
        Me.tb_c.Font = New System.Drawing.Font("Lucida Sans", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_c.Location = New System.Drawing.Point(197, 103)
        Me.tb_c.Name = "tb_c"
        Me.tb_c.Size = New System.Drawing.Size(69, 20)
        Me.tb_c.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Copperplate Gothic Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(75, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 12)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Delai critique ( D )"
        '
        'tb_d
        '
        Me.tb_d.Font = New System.Drawing.Font("Lucida Sans", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_d.Location = New System.Drawing.Point(197, 129)
        Me.tb_d.Name = "tb_d"
        Me.tb_d.Size = New System.Drawing.Size(69, 20)
        Me.tb_d.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 12)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Durée d'execution max ( C )"
        '
        'tb_r
        '
        Me.tb_r.Font = New System.Drawing.Font("Lucida Sans", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_r.Location = New System.Drawing.Point(197, 77)
        Me.tb_r.Name = "tb_r"
        Me.tb_r.Size = New System.Drawing.Size(69, 20)
        Me.tb_r.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 12)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Date de reveil ( R )"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Copperplate Gothic Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(112, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 12)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Periode ( P )"
        '
        'tb_p
        '
        Me.tb_p.Font = New System.Drawing.Font("Lucida Sans", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_p.Location = New System.Drawing.Point(197, 155)
        Me.tb_p.Name = "tb_p"
        Me.tb_p.Size = New System.Drawing.Size(69, 20)
        Me.tb_p.TabIndex = 39
        '
        'bt_terminer
        '
        Me.bt_terminer.BackColor = System.Drawing.Color.Transparent
        Me.bt_terminer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_terminer.Font = New System.Drawing.Font("Copperplate Gothic Light", 10.0!)
        Me.bt_terminer.Location = New System.Drawing.Point(293, 151)
        Me.bt_terminer.Name = "bt_terminer"
        Me.bt_terminer.Size = New System.Drawing.Size(117, 24)
        Me.bt_terminer.TabIndex = 42
        Me.bt_terminer.Text = "Terminer"
        Me.bt_terminer.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 17)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "AJOUTER UNE TACHE"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(465, 220)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_terminer)
        Me.Controls.Add(Me.bt_ajouter)
        Me.Controls.Add(Me.tb_c)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_d)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_r)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_p)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(465, 260)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajout d'une tache"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_ajouter As System.Windows.Forms.Button
    Friend WithEvents tb_c As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_d As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_r As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tb_p As System.Windows.Forms.TextBox
    Friend WithEvents bt_terminer As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
