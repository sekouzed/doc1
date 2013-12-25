Public Class Form2

    Private Sub bt_ajouter_Click(sender As Object, e As EventArgs) Handles bt_ajouter.Click
        Try
            Dim NewTache As tache = New tache

            NewTache.c = Integer.Parse(tb_c.Text)
            NewTache.d = Integer.Parse(tb_d.Text)
            NewTache.r0 = Integer.Parse(tb_r.Text)
            NewTache.p = Integer.Parse(tb_p.Text)
            NewTache.cr = NewTache.c
            NewTache.echeance = NewTache.d + NewTache.r0
            NewTache.laxite = NewTache.d + NewTache.r0 - NewTache.c


            tache.liseDesTaches.Add(NewTache)

            Dim i As Integer = 1

            FormMain.lb_listeDesTaches.Items.Clear()
            FormMain.lb_listeDesTaches.Update()

            For Each T As tache In tache.liseDesTaches
                T.numero = i
                FormMain.lb_listeDesTaches.Items.Add("TP " & T.numero & " ( R : " & T.r0 & " , C : " & T.c & " , D : " & T.d & " , P : " & T.p & " )")
                i = i + 1
            Next

            FormMain.lb_listeDesTaches.EndUpdate()

            tache.periodeDetude = Outil.ppcmDesTaches()
            FormMain.Label1.Text = "le PPCM des taches = " & tache.periodeDetude

            tb_c.Clear()
            tb_d.Clear()
            tb_p.Clear()
            tb_r.Clear()

        Catch ex As FormatException
            MsgBox("Les valeurs saisie sont incorrectes")
        End Try

    End Sub

    Private Sub bt_terminer_Click(sender As Object, e As EventArgs) Handles bt_terminer.Click
        Me.Dispose()
    End Sub
End Class