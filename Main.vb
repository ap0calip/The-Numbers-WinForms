Public Class frmLevel1
    'Programa basado en la aplicacion creada en el 2008
    'Fecha de comienzo 7 de mayo de 2019

    'Declarando variables publicas
    Public Numero1 As Integer = 0
    Public Numero2 As Integer = 0
    Public Total As Integer = 0
    Public Gift As Integer = 0
    Public GoodCount As Integer = 0
    Public strOpt As String = "Addition"
    Public intLevel As Integer = 10
    Public strGender As String = "Boy"
    'Variables para agrandar componentes segun tamaño de la ventana
    Dim CuRHeight As Integer = Me.Height
    Dim CuRWidth As Integer = Me.Width

    'Procedimiento para actualizar las imagenes
    Public Sub UpdImg()
        'Update picture Total
        Select Case txtTotal.Text
            Case 0
                picTotal.Image = TheNumbers.My.Resources._0
            Case 1
                picTotal.Image = TheNumbers.My.Resources._1
            Case 2
                picTotal.Image = TheNumbers.My.Resources._2
            Case 3
                picTotal.Image = TheNumbers.My.Resources._3
            Case 4
                picTotal.Image = TheNumbers.My.Resources._4
            Case 5
                picTotal.Image = TheNumbers.My.Resources._5
            Case 6
                picTotal.Image = TheNumbers.My.Resources._6
            Case 7
                picTotal.Image = TheNumbers.My.Resources._7
            Case 8
                picTotal.Image = TheNumbers.My.Resources._8
            Case 9
                picTotal.Image = TheNumbers.My.Resources._9
            Case 10
                picTotal.Image = TheNumbers.My.Resources._10
            Case 11
                picTotal.Image = TheNumbers.My.Resources._11
            Case 12
                picTotal.Image = TheNumbers.My.Resources._12
            Case Else
                picTotal.Image = TheNumbers.My.Resources._13
        End Select
        'Update picture Number1
        Select Case lblNumber1.Text
            Case 0
                picNumber1.Image = TheNumbers.My.Resources._0
            Case 1
                picNumber1.Image = TheNumbers.My.Resources._1
            Case 2
                picNumber1.Image = TheNumbers.My.Resources._2
            Case 3
                picNumber1.Image = TheNumbers.My.Resources._3
            Case 4
                picNumber1.Image = TheNumbers.My.Resources._4
            Case 5
                picNumber1.Image = TheNumbers.My.Resources._5
            Case 6
                picNumber1.Image = TheNumbers.My.Resources._6
            Case 7
                picNumber1.Image = TheNumbers.My.Resources._7
            Case 8
                picNumber1.Image = TheNumbers.My.Resources._8
            Case 9
                picNumber1.Image = TheNumbers.My.Resources._9
            Case 10
                picNumber1.Image = TheNumbers.My.Resources._10
            Case 11
                picNumber1.Image = TheNumbers.My.Resources._11
            Case 12
                picNumber1.Image = TheNumbers.My.Resources._12
            Case Else
                picNumber1.Image = TheNumbers.My.Resources._13
        End Select
        'Update picture Number2
        Select Case lblNumber2.Text
            Case 0
                picNumber2.Image = TheNumbers.My.Resources._0
            Case 1
                picNumber2.Image = TheNumbers.My.Resources._1
            Case 2
                picNumber2.Image = TheNumbers.My.Resources._2
            Case 3
                picNumber2.Image = TheNumbers.My.Resources._3
            Case 4
                picNumber2.Image = TheNumbers.My.Resources._4
            Case 5
                picNumber2.Image = TheNumbers.My.Resources._5
            Case 6
                picNumber2.Image = TheNumbers.My.Resources._6
            Case 7
                picNumber2.Image = TheNumbers.My.Resources._7
            Case 8
                picNumber2.Image = TheNumbers.My.Resources._8
            Case 9
                picNumber2.Image = TheNumbers.My.Resources._9
            Case 10
                picNumber2.Image = TheNumbers.My.Resources._10
            Case 11
                picNumber2.Image = TheNumbers.My.Resources._11
            Case 12
                picNumber2.Image = TheNumbers.My.Resources._12
            Case Else
                picNumber2.Image = TheNumbers.My.Resources._13
        End Select
    End Sub

    'Procedimiento para colocar bloques
    Public Sub BlockNumber()
        picBk1.Visible = True
        picBk2.Visible = True
        picBkTotal.Visible = True
    End Sub

    'Procedimiento para generar numeros
    Public Sub RdmNumA()
        'Inicializar la clase Random  
        Dim Entero As Integer

        'Inicializar la clase Random  
        Dim rdm As New Random()

        'Generar un random entre 0 y intLevel que no se repita
        Entero = rdm.Next(0, intLevel + 1)
        While Total = Entero
            Entero = rdm.Next(0, intLevel + 1)
        End While
        Total = Entero

        'Generar Numero1 pero que no se repita
        If Total <> 0 Then
            Entero = rdm.Next(0, Total + 1)
            While Numero1 = Entero
                Entero = rdm.Next(0, Total + 1)
            End While
            Numero1 = Entero
        Else
            Numero1 = 0
        End If

        Numero2 = Total - Numero1

        'Asignar numeros a los label
        lblNumber1.Text = Numero1
        lblNumber2.Text = Numero2
        txtTotal.Text = ""
        BlockNumber()
        UpdImg()
    End Sub

    'Generar numero para resta
    Public Sub RdmNumS()
        Dim Entero As Integer
        'Inicializar la clase Random  
        Dim rdm As New Random()

        ' generar un random entre 0 y intLevel
        Entero = rdm.Next(0, intLevel + 1)

        'Verificar que el Numero1 no se repita
        While Numero1 = Entero
            Entero = rdm.Next(0, intLevel + 1)
        End While
        Numero1 = Entero

        'Generar Numero2 pero que sea menor a numero1
        If Numero1 = 0 Then
            Entero = 0
        Else
            Entero = rdm.Next(0, Numero1 + 1)
            While Numero2 = Entero
                Entero = rdm.Next(0, Numero1 + 1)
            End While
        End If
        Numero2 = Entero

        Total = Numero1 - Numero2

        'Asiagnar numeros a los label
        lblNumber1.Text = Numero1
        lblNumber2.Text = Numero2
        txtTotal.Text = ""
        BlockNumber()
        UpdImg()
    End Sub

    'Generar numero de multiplicacion
    Public Sub RdmNumM()
        'Inicializar la clase Random  
        Dim rdm As New Random()

        'Asegura que el Numero1 no se repita
        While Numero1 = lblNumber1.Text
            Numero1 = rdm.Next(0, intLevel + 1)
        End While

        'Asegura que el Numero2 no se repita
        While Numero2 = lblNumber2.Text
            Numero2 = rdm.Next(0, intLevel + 1)
        End While

        'Asiagnar numeros a los label
        lblNumber1.Text = Numero1
        lblNumber2.Text = Numero2
        txtTotal.Text = ""
        BlockNumber()
        UpdImg()
    End Sub

    'Generar numero de divicion
    Public Sub RdmNumD()
        'Inicializar la clase Random  
        Dim rdm As New Random()

        Dim intTotal As Integer

        intTotal = rdm.Next(0, intLevel + 1)

        'Asegura que el Numero2 no se repita
        While Numero2 = lblNumber2.Text
            Numero2 = rdm.Next(1, intLevel + 1)
        End While

        Numero1 = intTotal * Numero2

        'Asiagnar numeros a los label
        lblNumber1.Text = Numero1
        lblNumber2.Text = Numero2
        txtTotal.Text = ""
        BlockNumber()
        UpdImg()
    End Sub

    'Procedimiento para mostar las estrellas
    Public Sub ShowStar()
        Select Case GoodCount
            Case 0
                GoodCount = 1
                star1.Visible = True
            Case 1
                GoodCount = 2
                star2.Visible = True
            Case 2
                GoodCount = 3
                star3.Visible = True
            Case 3
                GoodCount = 4
                star4.Visible = True
            Case 4
                GoodCount = 5
                star5.Visible = True
            Case 5
                GoodCount = 6
                star6.Visible = True
            Case 6
                GoodCount = 7
                star7.Visible = True
            Case 7
                GoodCount = 8
                star8.Visible = True
            Case 8
                GoodCount = 9
                star9.Visible = True
            Case Else
                While GoodCount > 0
                    StarDelete()
                End While
                ShowGift()
        End Select
    End Sub

    'Procedimiento para borrar estrellas
    Public Sub StarDelete()
        Select Case GoodCount
            Case 1
                star1.Visible = False
            Case 2
                star2.Visible = False
            Case 3
                star3.Visible = False
            Case 4
                star4.Visible = False
            Case 5
                star5.Visible = False
            Case 6
                star6.Visible = False
            Case 7
                star7.Visible = False
            Case 8
                star8.Visible = False
            Case 9
                star9.Visible = False
        End Select
        GoodCount -= 1 'GoodCount = GoodCount - 1
    End Sub

    'Procedimiento para mostrar el regalo
    Public Sub ShowGift()

        ' Initialize the random-number generator.
        Randomize()

        'randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        ' Generate random value between 1 and 20.
        Dim Value As Integer = CInt(Int((20 * Rnd()) + 1))
        While Value = Gift
            Value = CInt(Int((20 * Rnd()) + 1))
        End While
        Gift = Value
        'Update Gift picture
        If strGender = "Boy" Then
            Select Case Gift
                Case 1
                    frmGift.picGift.Image = TheNumbers.My.Resources.boy1
                Case 2
                    frmGift.picGift.Image = TheNumbers.My.Resources.boy2
                Case 3
                    frmGift.picGift.Image = TheNumbers.My.Resources.boy3
                Case 4
                    frmGift.picGift.Image = TheNumbers.My.Resources.boy4
                Case 5
                    frmGift.picGift.Image = TheNumbers.My.Resources.boy5
                Case 6
                    frmGift.picGift.Image = TheNumbers.My.Resources.boy6
                Case 7
                    frmGift.picGift.Image = TheNumbers.My.Resources.boy7
                Case 8
                    frmGift.picGift.Image = TheNumbers.My.Resources.boy8
                Case 9
                    frmGift.picGift.Image = TheNumbers.My.Resources.boy9
                Case 10
                    frmGift.picGift.Image = TheNumbers.My.Resources.boy10
                Case 11
                    frmGift.picGift.Image = TheNumbers.My.Resources.boy11
                Case 12
                    frmGift.picGift.Image = TheNumbers.My.Resources.boy12
                Case 13
                    frmGift.picGift.Image = TheNumbers.My.Resources.boy13
                Case 14
                    frmGift.picGift.Image = TheNumbers.My.Resources.boy14
                Case 15
                    frmGift.picGift.Image = TheNumbers.My.Resources.boy15
                Case 16
                    frmGift.picGift.Image = TheNumbers.My.Resources.boy16
                Case 17
                    frmGift.picGift.Image = TheNumbers.My.Resources.boy17
                Case 18
                    frmGift.picGift.Image = TheNumbers.My.Resources.boy18
                Case 19
                    frmGift.picGift.Image = TheNumbers.My.Resources.boy19
                Case 20
                    frmGift.picGift.Image = TheNumbers.My.Resources.boy20
            End Select
        Else
            Select Case Gift
                Case 1
                    frmGift.picGift.Image = TheNumbers.My.Resources.girl1
                Case 2
                    frmGift.picGift.Image = TheNumbers.My.Resources.girl2
                Case 3
                    frmGift.picGift.Image = TheNumbers.My.Resources.girl3
                Case 4
                    frmGift.picGift.Image = TheNumbers.My.Resources.girl4
                Case 5
                    frmGift.picGift.Image = TheNumbers.My.Resources.girl5
                Case 6
                    frmGift.picGift.Image = TheNumbers.My.Resources.girl6
                Case 7
                    frmGift.picGift.Image = TheNumbers.My.Resources.girl7
                Case 8
                    frmGift.picGift.Image = TheNumbers.My.Resources.girl8
                Case 9
                    frmGift.picGift.Image = TheNumbers.My.Resources.girl9
                Case 10
                    frmGift.picGift.Image = TheNumbers.My.Resources.girl10
                Case 11
                    frmGift.picGift.Image = TheNumbers.My.Resources.girl11
                Case 12
                    frmGift.picGift.Image = TheNumbers.My.Resources.girl12
                Case 13
                    frmGift.picGift.Image = TheNumbers.My.Resources.girl13
                Case 14
                    frmGift.picGift.Image = TheNumbers.My.Resources.girl14
                Case 15
                    frmGift.picGift.Image = TheNumbers.My.Resources.girl15
                Case 16
                    frmGift.picGift.Image = TheNumbers.My.Resources.girl16
                Case 17
                    frmGift.picGift.Image = TheNumbers.My.Resources.girl17
                Case 18
                    frmGift.picGift.Image = TheNumbers.My.Resources.girl18
                Case 19
                    frmGift.picGift.Image = TheNumbers.My.Resources.girl19
                Case 20
                    frmGift.picGift.Image = TheNumbers.My.Resources.girl20
            End Select
        End If
        frmGift.ShowDialog()
    End Sub

    'Procedimiento para cambiar de operador
    Public Sub ChangedMenu()
        While GoodCount > 0
            StarDelete()
        End While
        stbArithmetic.Text = "Arithmetic: " + strOpt
        stbLevel.Text = "Level: " + CStr(intLevel)
        stbChild.Text = "Child: " & strGender
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RdmNumA()
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If intLevel = 10 And (strOpt = "Addition" Or strOpt = "Subtraction") Then
            txtTotal.Text = 0
        Else
            txtTotal.Text = txtTotal.Text + "0"
        End If
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If intLevel = 10 And (strOpt = "Addition" Or strOpt = "Subtraction") Then
            txtTotal.Text = 1
        Else
            txtTotal.Text = txtTotal.Text + "1"
        End If
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If intLevel = 10 And (strOpt = "Addition" Or strOpt = "Subtraction") Then
            txtTotal.Text = 2
        Else
            txtTotal.Text = txtTotal.Text + "2"
        End If
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If intLevel = 10 And (strOpt = "Addition" Or strOpt = "Subtraction") Then
            txtTotal.Text = 3
        Else
            txtTotal.Text = txtTotal.Text + "3"
        End If
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If intLevel = 10 And (strOpt = "Addition" Or strOpt = "Subtraction") Then
            txtTotal.Text = 4
        Else
            txtTotal.Text = txtTotal.Text + "4"
        End If
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If intLevel = 10 And (strOpt = "Addition" Or strOpt = "Subtraction") Then
            txtTotal.Text = 5
        Else
            txtTotal.Text = txtTotal.Text + "5"
        End If
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If intLevel = 10 And (strOpt = "Addition" Or strOpt = "Subtraction") Then
            txtTotal.Text = 6
        Else
            txtTotal.Text = txtTotal.Text + "6"
        End If
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If intLevel = 10 And (strOpt = "Addition" Or strOpt = "Subtraction") Then
            txtTotal.Text = 7
        Else
            txtTotal.Text = txtTotal.Text + "7"
        End If
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If intLevel = 10 And (strOpt = "Addition" Or strOpt = "Subtraction") Then
            txtTotal.Text = 8
        Else
            txtTotal.Text = txtTotal.Text + "8"
        End If
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If intLevel = 10 And (strOpt = "Addition" Or strOpt = "Subtraction") Then
            txtTotal.Text = 9
        Else
            txtTotal.Text = txtTotal.Text + "9"
        End If
    End Sub

    Private Sub Btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        If intLevel = 10 And (strOpt = "Addition" Or strOpt = "Subtraction") Then
            txtTotal.Text = 10
        Else
            txtTotal.Text = txtTotal.Text + "10"
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTotal.Text = ""
    End Sub

    Private Sub TxtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        If txtTotal.Text Is "" Then
            picTotal.Image = TheNumbers.My.Resources._0
        Else
            If IsNumeric(txtTotal.Text) Then
                UpdImg()
            Else
                txtTotal.Clear()
            End If
        End If
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Select Case strOpt
            Case "Addition"
                If txtTotal.Text IsNot "" Then
                    If Numero1 + Numero2 = txtTotal.Text Then
                        RdmNumA()
                        ShowStar()
                    Else
                        If GoodCount > 0 Then
                            StarDelete()
                        End If
                        txtTotal.Text = ""
                        FrmWrongNumber.ShowDialog()
                    End If
                End If
            Case "Subtraction"
                If txtTotal.Text IsNot "" Then
                    If Numero1 - Numero2 = txtTotal.Text Then
                        RdmNumS()
                        ShowStar()
                    Else
                        If GoodCount > 0 Then
                            StarDelete()
                        End If
                        txtTotal.Text = ""
                        FrmWrongNumber.ShowDialog()
                    End If
                End If
            Case "Multiplication"
                If txtTotal.Text IsNot "" Then
                    If Numero1 * Numero2 = txtTotal.Text Then
                        RdmNumM()
                        ShowStar()
                    Else
                        If GoodCount > 0 Then
                            StarDelete()
                        End If
                        txtTotal.Text = ""
                        FrmWrongNumber.ShowDialog()
                    End If
                End If
            Case "Division"
                If txtTotal.Text IsNot "" Then
                    If Numero1 / Numero2 = txtTotal.Text Then
                        RdmNumD()
                        ShowStar()
                    Else
                        If GoodCount > 0 Then
                            StarDelete()
                        End If
                        txtTotal.Text = ""
                        FrmWrongNumber.ShowDialog()
                    End If
                End If
        End Select
    End Sub

    Private Sub PicBk1_Click(sender As Object, e As EventArgs) Handles picBk1.Click
        picBk1.Visible = Not (picBk1.Visible)
    End Sub

    Private Sub PicNumber1_Click(sender As Object, e As EventArgs) Handles picNumber1.Click
        picBk1.Visible = Not (picBk1.Visible)
    End Sub

    Private Sub PicBk2_Click(sender As Object, e As EventArgs) Handles picBk2.Click
        picBk2.Visible = Not (picBk2.Visible)
    End Sub

    Private Sub PicNumber2_Click(sender As Object, e As EventArgs) Handles picNumber2.Click
        picBk2.Visible = Not (picBk2.Visible)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnExit.Click
        Close()
    End Sub

    Private Sub Mn10Addition_Click(sender As Object, e As EventArgs) Handles mn10Addition.Click
        strOpt = "Addition"
        intLevel = 10
        RdmNumA()
        ChangedMenu()
    End Sub

    Private Sub Mn12Addition_Click(sender As Object, e As EventArgs) Handles mn12Addition.Click
        strOpt = "Addition"
        intLevel = 12
        RdmNumA()
        ChangedMenu()
    End Sub

    Private Sub Mn20Addition_Click(sender As Object, e As EventArgs) Handles mn20Addition.Click
        strOpt = "Addition"
        intLevel = 20
        RdmNumA()
        ChangedMenu()
    End Sub

    Private Sub Mn100Addition_Click(sender As Object, e As EventArgs) Handles mn100Addition.Click
        strOpt = "Addition"
        intLevel = 100
        RdmNumA()
        ChangedMenu()
    End Sub

    Private Sub Mn10Subtraction_Click(sender As Object, e As EventArgs) Handles mn10Subtraction.Click
        strOpt = "Subtraction"
        intLevel = 10
        RdmNumS()
        ChangedMenu()
    End Sub

    Private Sub Mn12Subtraction_Click(sender As Object, e As EventArgs) Handles mn12Subtraction.Click
        strOpt = "Subtraction"
        intLevel = 12
        RdmNumS()
        ChangedMenu()
    End Sub

    Private Sub Mn20Subtraction_Click(sender As Object, e As EventArgs) Handles mn20Subtraction.Click
        strOpt = "Subtraction"
        intLevel = 20
        RdmNumS()
        ChangedMenu()
    End Sub

    Private Sub Mn100Subtraction_Click(sender As Object, e As EventArgs) Handles mn100Subtraction.Click
        strOpt = "Subtraction"
        intLevel = 100
        RdmNumS()
        ChangedMenu()
    End Sub

    Private Sub MnAddition_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnAddition.DropDownItemClicked
        lblOperator1.Text = "+"
        lblOperator2.Text = "+"
    End Sub

    Private Sub MnSubtraction_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnSubtraction.DropDownItemClicked
        lblOperator1.Text = "-"
        lblOperator2.Text = "-"
    End Sub

    Private Sub MnMultiplication_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnMultiplication.DropDownItemClicked
        lblOperator1.Text = "x"
        lblOperator2.Text = "x"
    End Sub

    Private Sub MnDivision_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnDivision.DropDownItemClicked
        lblOperator1.Text = "÷"
        lblOperator2.Text = "÷"
    End Sub

    Private Sub Mn10Multiplication_Click(sender As Object, e As EventArgs) Handles Up10M.Click
        strOpt = "Multiplication"
        intLevel = 10
        RdmNumM()
        ChangedMenu()
    End Sub

    Private Sub Mn12Multiplication_Click(sender As Object, e As EventArgs) Handles Up12M.Click
        strOpt = "Multiplication"
        intLevel = 12
        RdmNumM()
        ChangedMenu()
    End Sub

    Private Sub Mn10Division_Click(sender As Object, e As EventArgs) Handles Up10D.Click
        strOpt = "Division"
        intLevel = 10
        RdmNumD()
        ChangedMenu()
    End Sub

    Private Sub Mn12Division_Click(sender As Object, e As EventArgs) Handles Up12D.Click
        strOpt = "Division"
        intLevel = 12
        RdmNumD()
        ChangedMenu()
    End Sub

    Private Sub MasculineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasculineToolStripMenuItem.Click
        strGender = "Boy"
        ChangedMenu()
    End Sub

    Private Sub FemeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FemeToolStripMenuItem.Click
        strGender = "Girl"
        ChangedMenu()
    End Sub

    Private Sub PicBkTotal_Click(sender As Object, e As EventArgs) Handles picBkTotal.Click
        picBkTotal.Visible = Not (picBkTotal.Visible)
    End Sub

    Private Sub PicTotal_Click(sender As Object, e As EventArgs) Handles picTotal.Click
        picBkTotal.Visible = Not (picBkTotal.Visible)
    End Sub


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("The Numbers" & vbNewLine & "Version 1.0.0" & vbNewLine & "2019 forcomputer" &
               vbNewLine & "All rights reserved" & vbNewLine & "" & vbNewLine & "Coder: Wilbert Martinez" & vbNewLine & "Start date: 05-07-19" & vbNewLine & "" &
               vbNewLine & "Images:" & vbNewLine & "Megaman and Zero: William Liu (Freelance Artist)" & vbNewLine & "http://pngimg.com/" & vbNewLine & "https://imgbin.com/" &
               vbNewLine & "References:" & vbNewLine & "http://www.recursosvisualbasic.com.ar/" & vbNewLine & "https://www.homeandlearn.co.uk/NET/vbNet.html" &
               vbNewLine & "https://www.tutorialspoint.com/vb.net/index.htm", vbOKOnly, "About")
    End Sub

    Private Sub DedicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DedicationToolStripMenuItem.Click
        MsgBox("Dedicado a mi hijo: Bryan Jayson" & vbNewLine &
               "En el 2008 creé la primera versión llamada Los Números, para ayudar a mi hijo a aprender a sumar del 1 al 10.", vbOKOnly, "Dedication")
    End Sub

    'Procedimiento para agrandar los componentes segun tamaño de ventana
    Private Sub FrmLevel1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim RatioHeight As Double = (Me.Height - CuRHeight) / CuRHeight
        Dim RatioWidth As Double = (Me.Width - CuRWidth) / CuRWidth

        For Each ctrl As Control In Controls
            ctrl.Width += ctrl.Width * RatioWidth
            ctrl.Height += ctrl.Height * RatioHeight
            ctrl.Left += ctrl.Left * RatioWidth
            ctrl.Top += ctrl.Top * RatioHeight
        Next
        CuRHeight = Me.Height
        CuRWidth = Me.Width
    End Sub
End Class
