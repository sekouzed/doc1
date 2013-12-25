Public Class Schemas

#Region "Declaration"

    Public Shared schemas As Bitmap
    Public Shared XtailleMax As Integer
    Public Shared YtailleMax As Integer
    Public Shared unite As Integer = 20
    Public Shared marge As Integer = 2 * unite
    Public Shared hauteur As Integer = 4 * unite

#End Region

#Region "La grille et repere"

    Public Shared Sub grille()
        Dim g As Graphics = Graphics.FromImage(schemas)
        Dim pen As Pen = New Pen(Color.Green, 1)
        pen.DashStyle = Drawing2D.DashStyle.Dot

        Dim i As Integer


        'les ligne horizontal
        For i = 0 To YtailleMax
            g.DrawLine(pen, 0, i * unite, XtailleMax, i * unite)
        Next

        'les ligne vertical
        For i = 0 To XtailleMax
            g.DrawLine(pen, i * unite, 0, i * unite, YtailleMax)
        Next

        g.Dispose()

    End Sub

    Public Shared Sub repere()

        Dim g As Graphics = Graphics.FromImage(schemas)
        Dim penSupport As Pen = New Pen(Color.Black, 3)
        penSupport.EndCap = Drawing2D.LineCap.ArrowAnchor
        Dim flecheD As Pen = New Pen(Color.Red, 3)
        flecheD.EndCap = Drawing2D.LineCap.ArrowAnchor
        Dim flecheP As Pen = New Pen(Color.Blue, 3)
        flecheP.StartCap = Drawing2D.LineCap.ArrowAnchor

        Dim periodeDetude As Integer = tache.periodeDetude * unite
        Dim i As Integer = 1
        FormMain.pb_schemas.Controls.Clear()

        For Each t As tache In tache.liseDesTaches
            'nom des taches
            Dim lab As Label = New Label
            lab.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
            lab.AutoSize = True
            lab.Text = "TP " & t.numero & " ( R = " & t.r0 & " ; C = " & t.c & " ; D = " & t.d & " ; P = " & t.p & " )"
            lab.Location = New System.Drawing.Point(marge + 10, hauteur * i - 2 * unite)
            FormMain.pb_schemas.Controls.Add(lab)

            'ligne de support verticale du repere  pour chaque tache
            g.DrawLine(penSupport, marge, hauteur * i, marge, hauteur * i - 2 * unite)
            'ligne de support horizontal du repere pour chaque tache
            g.DrawLine(penSupport, marge, hauteur * i, marge + periodeDetude + unite, hauteur * i)

            'Numerotation des supports
            For k As Integer = marge To XtailleMax - marge Step unite
                Dim labNum As Label = New Label
                labNum.Font = New System.Drawing.Font("Arial", 8.0!)
                labNum.AutoSize = True
                labNum.Text = "" & (k - marge) / unite
                labNum.Location = New System.Drawing.Point(k - 5, hauteur * i + 2)
                FormMain.pb_schemas.Controls.Add(labNum)
            Next

            Dim rk As Integer = t.r0 * unite + marge
            Dim dk As Integer = rk + t.d * unite
            While (rk < periodeDetude)
                g.DrawLine(flecheD, dk, hauteur * i - unite, dk, hauteur * i)     'fleche des delai critiq dk
                rk = rk + t.p * unite
                dk = rk + t.d * unite
                g.DrawLine(flecheP, rk, hauteur * i - unite, rk, hauteur * i)   'fleche des dates de reveil rk
            End While

            i = i + 1
        Next

        g.Dispose()

    End Sub
#End Region


#Region "ordonnancement"

    Public Shared Sub algotest()

        'Dim g As Graphics = Graphics.FromImage(schemas)
        ''Dim pen As Pen = New Pen(Color.Black, 2)
        'Dim pen As Brush = Brushes.Black

        'FormMain.lb_note.Items.Clear()
        'FormMain.lb_note.Update()
        'FormMain.lb_note.Items.Add("Ordre de priorité des taches")
        'FormMain.lb_note.Items.Add("-----------------------------")

        'repere()
        ''debut algo
        'Dim T As Integer = 0
        'Dim i As Integer
        'Dim tracer As Boolean = False

        'While (T < tache.periodeDetude)
        '    i = 0
        '    tache.liseDesTaches.Sort(New comparePeriode)

        '    While (i < tache.liseDesTaches.Count Or tracer = False)
        '        If (tache.liseDesTaches.ElementAt(i).cr > 0) Then 'And T <= tache.liseDesTaches.ElementAt(i).echeance) Then  'ou p < tache.liseDesTaches.ElementAt(0).r + tache.liseDesTaches.ElementAt(0).d
        '            g.FillRectangle(pen, T * unite + marge, hauteur * tache.liseDesTaches.ElementAt(i).numero - 15, unite, 15)
        '            tache.liseDesTaches.ElementAt(i).cr = tache.liseDesTaches.ElementAt(i).cr - 1
        '            tracer = True

        '            FormMain.lb_note.Items.Add(" à t = " & T)
        '            For Each tach As tache In tache.liseDesTaches
        '                FormMain.lb_note.Items.Add("   TP" & tach.numero & " : Periode = " & tach.p)
        '            Next

        '            T = T + 1
        '        Else
        '            tache.liseDesTaches.ElementAt(i).cr = tache.liseDesTaches.ElementAt(i).c
        '            tache.liseDesTaches.ElementAt(i).rk = tache.liseDesTaches.ElementAt(i).rk + tache.liseDesTaches.ElementAt(i).p
        '            i = i + 1
        '        End If
        '        If (i = tache.liseDesTaches.Count) Then
        '            Exit While
        '        End If
        '    End While
        'End While
        ''fin algo

        'g.Dispose()
        'FormMain.lb_note.EndUpdate()

        ''réinitialisation de la liste des tache
        'For Each tach As tache In tache.liseDesTaches
        '    tach.rk = tach.r0
        '    tach.cr = tach.c
        'Next
        'tache.liseDesTaches.Sort(New compareNumero)

    End Sub


    Public Shared Sub RateMonotonic()

        Dim g As Graphics = Graphics.FromImage(schemas)
        Dim pen As Brush = Brushes.Black

        'tri de la liste par priorité du plus petit (p)
        tache.liseDesTaches.Sort(New comparePeriode)

        FormMain.lb_note.Items.Clear()
        FormMain.lb_note.Update()
        FormMain.lb_note.Items.Add("-----------------------------")
        FormMain.lb_note.Items.Add("CONDITON D'ORDONNANCABILITE")
        FormMain.lb_note.Items.Add("-----------------------------")
        Dim u, nfact As Double
        u = Outil.facteurDutilisation()
        FormMain.lb_note.Items.Add("Facteur d'utilisation U=" & u)
        nfact = tache.liseDesTaches.Count * (Math.Pow(2, 1 / tache.liseDesTaches.Count) - 1)
        If (u <= nfact) Then
            FormMain.lb_note.Items.Add(" U <= " & nfact & ", Condition verifiée")
        Else
            FormMain.lb_note.Items.Add(" U > " & nfact & ", Condition non verifiée")
        End If
        FormMain.lb_note.Items.Add("-----------------------------")
        FormMain.lb_note.Items.Add("ORDRE DE PRIORITE DES TACHES")
        FormMain.lb_note.Items.Add("-----------------------------")
        For Each ta As tache In tache.liseDesTaches
            FormMain.lb_note.Items.Add("   TP " & ta.numero & " : Delai critique = " & ta.p)
        Next
        FormMain.lb_note.EndUpdate()


        Dim periodeDetude As Integer = tache.periodeDetude * unite
        Dim tableDexecution(tache.periodeDetude) As Integer

        For k As Integer = 0 To tableDexecution.Count - 1
            tableDexecution(k) = 0
        Next


        repere()
        Dim i As Integer = 1
        For Each t As tache In tache.liseDesTaches

            Dim c, rkt, e As Integer
            Dim rk As Integer = t.r0 * unite + marge
            Dim dk As Integer = rk + t.d * unite

            While (rk < periodeDetude)
                c = t.c
                rkt = rk
                While (c > 0)
                    e = (rkt - marge) / unite
                    If (tableDexecution(e) = 0) Then
                        If (rkt >= rk + t.d * unite) Then
                            FormMain.Label1.Text = "Il ya une faute temporaire"
                            MsgBox("Il ya une faute temporaire")
                            'pen = Brushes.Red
                            Return
                        End If
                        g.FillRectangle(pen, rkt, hauteur * i - 15, unite, 15)
                        tableDexecution(e) = 1
                        c = c - 1
                    End If
                    rkt = rkt + unite
                End While
                rk = rk + t.p * unite
                dk = rk + t.d * unite
            End While

            i = i + 1
        Next

        tache.liseDesTaches.Sort(New compareNumero)
        g.Dispose()

    End Sub

    Public Shared Sub InverseDeadline()

        Dim g As Graphics = Graphics.FromImage(schemas)
        Dim pen As Brush = Brushes.Black

        'tri de la liste par priorité du plus petit (d)
        tache.liseDesTaches.Sort(New compareDelaiCritique)

        FormMain.lb_note.Items.Clear()
        FormMain.lb_note.Update()
        FormMain.lb_note.Items.Add("-----------------------------")
        FormMain.lb_note.Items.Add("CONDITON D'ORDONNANCABILITE")
        FormMain.lb_note.Items.Add("-----------------------------")
        Dim ch, nfact As Double
        ch = Outil.facteurDeCharge()
        FormMain.lb_note.Items.Add("Facteur de charge CH=" & ch)
        nfact = tache.liseDesTaches.Count * (Math.Pow(2, 1 / tache.liseDesTaches.Count) - 1)
        If (ch <= nfact) Then
            FormMain.lb_note.Items.Add(" CH <= " & nfact & ", Condition verifiée")
        Else
            FormMain.lb_note.Items.Add(" CH > " & nfact & ", Condition non verifiée")
        End If
        FormMain.lb_note.Items.Add("-----------------------------")
        FormMain.lb_note.Items.Add("ORDRE DE PRIORITE DES TACHES")
        FormMain.lb_note.Items.Add("-----------------------------")
        For Each ta As tache In tache.liseDesTaches
            FormMain.lb_note.Items.Add("   TP " & ta.numero & " : Delai critique = " & ta.d)
        Next
        FormMain.lb_note.EndUpdate()


        Dim periodeDetude As Integer = tache.periodeDetude * unite
        Dim tableDexecution(tache.periodeDetude) As Integer

        For u As Integer = 0 To tableDexecution.Count - 1
            tableDexecution(u) = 0
        Next


        repere()
        Dim i As Integer = 1
        For Each t As tache In tache.liseDesTaches

            Dim c, rkt, e As Integer
            Dim rk As Integer = t.r0 * unite + marge
            Dim dk As Integer = rk + t.d * unite

            While (rk < periodeDetude)
                c = t.c
                rkt = rk
                While (c > 0)
                    e = (rkt - marge) / unite
                    If (tableDexecution(e) = 0) Then
                        If (rkt >= rk + t.d * unite) Then
                            FormMain.Label1.Text = "Il ya une faute temporaire"
                            MsgBox("Il ya une faute temporaire")
                            'pen = Brushes.Red
                            Return
                        End If
                        g.FillRectangle(pen, rkt, hauteur * i - 15, unite, 15)
                        tableDexecution(e) = 1
                        c = c - 1
                    End If
                    rkt = rkt + unite
                End While
                rk = rk + t.p * unite
                dk = rk + t.d * unite
            End While

            i = i + 1
        Next

        tache.liseDesTaches.Sort(New compareNumero)
        g.Dispose()

    End Sub

    Public Shared Sub EarliestDeadline()

        Dim g As Graphics = Graphics.FromImage(schemas)
        'Dim pen As Pen = New Pen(Color.Black, 2)
        Dim pen As Brush = Brushes.Black

        FormMain.lb_note.Items.Clear()
        FormMain.lb_note.Update()
        FormMain.lb_note.Items.Add("-----------------------------")
        FormMain.lb_note.Items.Add("CONDITON D'ORDONNANCABILITE")
        FormMain.lb_note.Items.Add("-----------------------------")
        Dim u As Double = Outil.facteurDutilisation()
        FormMain.lb_note.Items.Add("Facteur d'utilisation U=" & u)
        If (u <= 1) Then
            FormMain.lb_note.Items.Add(" U <= 1, Condition necessaire verifiée")
        Else
            FormMain.lb_note.Items.Add(" U > 1, Condition necessaire non verifiée")
        End If

        Dim ch As Double = Outil.facteurDeCharge()
        FormMain.lb_note.Items.Add("Facteur de charger CH=" & ch)
        If (ch <= 1) Then
            FormMain.lb_note.Items.Add(" CH <= 1, Condition suffissante verifiée")
        Else
            FormMain.lb_note.Items.Add(" CH > 1, Condition suffissante non verifiée")
        End If

        FormMain.lb_note.Items.Add("-----------------------------")
        FormMain.lb_note.Items.Add("ORDRE DE PRIORITE DES TACHES")
        FormMain.lb_note.Items.Add("-----------------------------")

        repere()
        'debut algo
        Dim T As Integer = 0
        While (T < tache.periodeDetude)

            tache.liseDesTaches.Sort(New compareEcheance)
            FormMain.lb_note.Items.Add(" à t = " & T)
            For Each tach As tache In tache.liseDesTaches
                FormMain.lb_note.Items.Add("   TP" & tach.numero & " : echeance = " & tach.echeance)
            Next

            If (tache.liseDesTaches.ElementAt(0).rk <= T And T <= tache.liseDesTaches.ElementAt(0).echeance) Then  'ou p < tache.liseDesTaches.ElementAt(0).r + tache.liseDesTaches.ElementAt(0).d
                g.FillRectangle(pen, T * unite + marge, hauteur * tache.liseDesTaches.ElementAt(0).numero - 15, tache.liseDesTaches.ElementAt(0).c * unite, 15)

                tache.liseDesTaches.ElementAt(0).rk = tache.liseDesTaches.ElementAt(0).rk + tache.liseDesTaches.ElementAt(0).p
                T = T + tache.liseDesTaches.ElementAt(0).c
            Else
                T = T + 1
            End If
        End While
        'fin algo

        g.Dispose()
        FormMain.lb_note.EndUpdate()

        'réinitialisation de la liste des tache
        For Each tach As tache In tache.liseDesTaches
            tach.rk = tach.r0
        Next
        tache.liseDesTaches.Sort(New compareNumero)

    End Sub

    Shared Function tracerAlgo(ByVal t As Integer, ByVal i As Integer)
        Dim g As Graphics = Graphics.FromImage(schemas)
        Dim pen As Brush = Brushes.Black

        If (tache.liseDesTaches.ElementAt(i).rk <= t And t <= (tache.liseDesTaches.ElementAt(i).rk + tache.liseDesTaches.ElementAt(i).d)) Then  'ou p < tache.liseDesTaches.ElementAt(0).r + tache.liseDesTaches.ElementAt(0).d
            g.FillRectangle(pen, t * unite + marge, hauteur * tache.liseDesTaches.ElementAt(i).numero - 15, tache.liseDesTaches.ElementAt(i).c * unite, 15)

            g.Dispose()
            tache.liseDesTaches.ElementAt(i).rk = tache.liseDesTaches.ElementAt(i).rk + tache.liseDesTaches.ElementAt(i).p
            Return t + tache.liseDesTaches.ElementAt(i).c
        Else
            If (tache.liseDesTaches.ElementAt(i).laxite = tache.liseDesTaches.ElementAt(i + 1).laxite) Then
                tracerAlgo(t, i + 1)
            End If
        End If
        Return t + 1
    End Function

    Public Shared Sub LeastLaxity()

        Dim g As Graphics = Graphics.FromImage(schemas)
        'Dim pen As Pen = New Pen(Color.Black, 2)
        Dim pen As Brush = Brushes.Black

        FormMain.lb_note.Items.Clear()
        FormMain.lb_note.Update()
        FormMain.lb_note.Items.Add("-----------------------------")
        FormMain.lb_note.Items.Add("CONDITON D'ORDONNANCABILITE")
        FormMain.lb_note.Items.Add("-----------------------------")
        Dim u As Double = Outil.facteurDutilisation()
        FormMain.lb_note.Items.Add("Facteur d'utilisation U=" & u)
        If (u <= 1) Then
            FormMain.lb_note.Items.Add(" U <= 1, Condition necessaire verifiée")
        Else
            FormMain.lb_note.Items.Add(" U > 1, Condition necessaire non verifiée")
        End If

        Dim ch As Double = Outil.facteurDeCharge()
        FormMain.lb_note.Items.Add("Facteur de charger CH=" & ch)
        If (ch <= 1) Then
            FormMain.lb_note.Items.Add(" CH <= 1, Condition suffissante verifiée")
        Else
            FormMain.lb_note.Items.Add(" CH > 1, Condition suffissante non verifiée")
        End If

        FormMain.lb_note.Items.Add("-----------------------------")
        FormMain.lb_note.Items.Add("ORDRE DE PRIORITE DES TACHES")
        FormMain.lb_note.Items.Add("-----------------------------")

        repere()
        'debut algo
        Dim T As Integer = 0
        Dim i As Integer = 0
        While (T < tache.periodeDetude)

            tache.liseDesTaches.Sort(New compareLaxite)
            FormMain.lb_note.Items.Add(" à t = " & T)
            For Each tach As tache In tache.liseDesTaches
                FormMain.lb_note.Items.Add("   TP" & tach.numero & " : laxité = " & tach.laxite)
            Next

            T = tracerAlgo(T, i)
        End While
        'fin algo

        g.Dispose()
        FormMain.lb_note.EndUpdate()

        'réinitialisation de la liste des tache
        For Each tach As tache In tache.liseDesTaches
            tach.rk = tach.r0
        Next
        tache.liseDesTaches.Sort(New compareNumero)

    End Sub

#End Region

End Class
