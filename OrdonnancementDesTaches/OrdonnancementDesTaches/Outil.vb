Public Class Outil

#Region "Calcul du PPCM"

    Public Shared Function ppcmDesTaches()

        Dim ppcmVal As Integer = tache.liseDesTaches.ElementAt(0).p

        For Each T As tache In tache.liseDesTaches
            ppcmVal = Outil.ppcm2valeur(ppcmVal, T.p)
        Next

        Return ppcmVal
    End Function

    Public Shared Function ppcm2valeur(ByVal a As Integer, ByVal b As Integer)
        Dim p As Integer = a * b
        While (a <> b)
            If (a < b) Then
                b = b - a
            Else
                a = a - b
            End If
        End While
        Return p / a
    End Function

    Public Shared Function facteurDutilisation()
        Dim u As Double= 0
        For Each ta As tache In tache.liseDesTaches
            u = u + ta.c / ta.p
        Next
        Return u
    End Function

    Public Shared Function facteurDeCharge()
        Dim ch As Double = 0
        For Each ta As tache In tache.liseDesTaches
            ch = ch + ta.c / ta.d
        Next
        Return ch
    End Function

#End Region


End Class

Public Class compareNumero
    Implements IComparer(Of tache)

    Public Function Compare(ByVal x As tache, ByVal y As tache) As Integer Implements System.Collections.Generic.IComparer(Of tache).Compare
        If x.numero < y.numero Then
            Return -1
        ElseIf x.numero = y.numero Then
            Return 0
        Else
            Return 1
        End If
    End Function
End Class

Public Class comparePeriode
    Implements IComparer(Of tache)

    Public Function Compare(ByVal x As tache, ByVal y As tache) As Integer Implements System.Collections.Generic.IComparer(Of tache).Compare
        If x.p < y.p Then
            Return -1
        ElseIf x.p = y.p Then
            Return 0
        Else
            Return 1
        End If
    End Function
End Class

Public Class compareDelaiCritique
    Implements IComparer(Of tache)

    Public Function Compare(ByVal x As tache, ByVal y As tache) As Integer Implements System.Collections.Generic.IComparer(Of tache).Compare
        If x.d < y.d Then
            Return -1
        ElseIf x.d = y.d Then
            Return 0
        Else
            Return 1
        End If
    End Function
End Class

Public Class compareEcheance
    Implements IComparer(Of tache)

    Public Function Compare(ByVal x As tache, ByVal y As tache) As Integer Implements System.Collections.Generic.IComparer(Of tache).Compare
        x.echeance = x.d + x.rk
        y.echeance = y.d + y.rk
        If x.echeance < y.echeance Then
            Return -1
        ElseIf x.echeance = y.echeance Then
            Return 0
        Else
            Return 1
        End If
    End Function
End Class

Public Class compareLaxite
    Implements IComparer(Of tache)

    Public Function Compare(ByVal x As tache, ByVal y As tache) As Integer Implements System.Collections.Generic.IComparer(Of tache).Compare
        x.laxite = x.d + x.rk - x.c
        y.laxite = y.d + y.rk - y.c
        If x.laxite < y.laxite Then
            Return -1
        ElseIf x.laxite = y.laxite Then
            Return 0
        Else
            Return 1
        End If
    End Function
End Class
