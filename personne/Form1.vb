Public Class Form1
    Dim x As DialogResult


    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        LDATE.Text = Now.ToShortDateString
        LHEURE.Text = Now.ToLongTimeString
    End Sub

   


    Private Sub BTNRAZ_Click(sender As Object, e As EventArgs) Handles BTNRAZ.Click
        If CPKG.Text = Nothing And CPG.Text = Nothing And CTM.Text = Nothing And CTC.Text = Nothing And RM.Checked = Nothing And RF.Checked = Nothing Then
            MessageBox.Show("Toutes les zones de textes sont vides", "Aucune Entrée", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            x = MessageBox.Show("Voulez Vous Vider Toutes les Zones de Textes ?", "Effaçage", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If x = MsgBoxResult.Yes Then
                Beep()
                CPKG.Text = Nothing
                CPG.Text = Nothing
                CTM.Text = Nothing
                CTC.Text = Nothing
                RM.Checked = Nothing
                RF.Checked = Nothing
                IMR.Text = Nothing
                OBR.Text = Nothing
                BTNTEST.Enabled = False
            End If
        End If
    End Sub


    Private Sub BTNQUITTER_Click(sender As Object, e As EventArgs) Handles BTNQUITTER.Click
        x = MessageBox.Show("Voulez vous fermer ?", "Fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = MsgBoxResult.Yes Then
            Beep()
            Application.Exit()
        End If
    End Sub

    Private Sub BTNTEST_Click(sender As Object, e As EventArgs) Handles BTNTEST.Click
        Dim taillem As Double
        Dim poidskg As Double
        Dim poidg As Double
        Dim taillecm As Double
        Dim taille As Double
        Dim calc As Double
        taillem = CTM.Text
        poidskg = CPKG.Text
        If CPG.Text = "" Then
            poidg = 0
        Else
            poidg = CPG.Text / (10 ^ 2)
        End If
        If CTC.Text = "" Then
            taillecm = 0
        Else
            taillecm = CTC.Text / (10 ^ 2)
        End If
        taille = taillem + taillecm
        calc = (poidskg + poidg) / (taille * taille)
        IMR.Text = calc


        If IMR.Text <= 18.5 Then
            IMR.Visible = True
            OBR.Visible = True
            OBR.Text = "Maigre"
        End If
        If IMR.Text > 18.5 And IMR.Text <= 25 Then
            IMR.Visible = True
            OBR.Visible = True
            OBR.Text = "Moyenne"
        End If
        If IMR.Text > 25 Then
            IMR.Visible = True
            OBR.Visible = True
            OBR.Text = "SurPoids"
        End If
    End Sub

    Private Sub CPKG_TextChanged(sender As Object, e As EventArgs) Handles CPKG.TextChanged
        If CTM.Text <> "" Then
            BTNTEST.Enabled = True
        End If
    End Sub

    Private Sub CTM_TextChanged(sender As Object, e As EventArgs) Handles CTM.TextChanged
        If CPKG.Text <> "" Then
            BTNTEST.Enabled = True
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RM.Checked = True
        BTNTEST.Enabled = False
    End Sub
End Class
