Public Class FormMain

    'Dim tacheCourante As tache
    Sub tracer()
        Schemas.marge = Schemas.unite * 2
        Schemas.hauteur = Schemas.unite * 3
        Schemas.XtailleMax = tache.periodeDetude * Schemas.unite + 2 * Schemas.marge
        Schemas.YtailleMax = tache.liseDesTaches.Count * Schemas.hauteur + Schemas.marge

        Schemas.schemas = New Bitmap(Schemas.XtailleMax, Schemas.YtailleMax)
        Label1.Text = "la periode d'etude = " & tache.periodeDetude
        Schemas.grille()

        'titre
        Dim titre As Label = New Label
        titre.Font = New System.Drawing.Font("Copperplate Gothic Light", 10.0!, System.Drawing.FontStyle.Underline)
        titre.AutoSize = True
        titre.Location = New System.Drawing.Point(Schemas.marge - Schemas.unite, 2)
        pb_schemas.Controls.Add(titre)

        If (cb_algo.SelectedIndex = 0) Then
            titre.Text = "Ordonnancement Rate Monotonic"
            Schemas.RateMonotonic()
        ElseIf (cb_algo.SelectedIndex = 1) Then
            titre.Text = "Ordonnancement Inverse Deadline"
            Schemas.InverseDeadline()
        ElseIf (cb_algo.SelectedIndex = 2) Then
            titre.Text = "Ordonnancement Earliest Deadline"
            Schemas.EarliestDeadline()
        ElseIf (cb_algo.SelectedIndex = 3) Then
            titre.Text = "Ordonnancement Least Laxity"
            Schemas.LeastLaxity()
        End If

        pb_schemas.Visible = True
        pb_schemas.Width = Schemas.XtailleMax + 1
        pb_schemas.Height = Schemas.YtailleMax + 1
        pb_schemas.BackgroundImage = Schemas.schemas
        pb_schemas.Refresh()
    End Sub


    Private Sub lb_listeDesTaches_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_listeDesTaches.SelectedIndexChanged
        EnleverMenu.Enabled = True
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        cb_algo.SelectedIndex = 0
        cb_zoom.SelectedIndex = 1
        ' Dim ajouterform As Form2 = New Form2()
        'ajouterform.ShowDialog()
    End Sub


    Private Sub FormMain_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If (tache.liseDesTaches.Count <> 0) Then
            tracer()
        End If
    End Sub

    Private Sub TRACERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TRACERToolStripMenuItem.Click
        If (tache.liseDesTaches.Count <> 0) Then
            tracer()
        End If
    End Sub

    Private Sub cb_zoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_zoom.SelectedIndexChanged
        Schemas.unite = (cb_zoom.SelectedIndex + 2) * 10
        If (tache.liseDesTaches.Count <> 0) Then
            tracer()
        End If
    End Sub

    Private Sub AjouterMenu_Click(sender As Object, e As EventArgs) Handles AjouterMenu.Click
        Dim ajouterform As Form2 = New Form2()
        ajouterform.ShowDialog()
    End Sub

    Private Sub EnleverMenu_Click(sender As Object, e As EventArgs) Handles EnleverMenu.Click
        If (Me.lb_listeDesTaches.SelectedIndex >= 0) Then
            tache.liseDesTaches.RemoveAt(Me.lb_listeDesTaches.SelectedIndex)
            Me.lb_listeDesTaches.Items.RemoveAt(Me.lb_listeDesTaches.SelectedIndex)
            tache.periodeDetude = Outil.ppcmDesTaches()
        End If
    End Sub

    Private Sub NettoyerMenu_Click(sender As Object, e As EventArgs) Handles NettoyerMenu.Click
        tache.liseDesTaches.Clear()
        lb_listeDesTaches.Items.Clear()
        lb_note.Items.Clear()
        pb_schemas.Visible = False
    End Sub
End Class
