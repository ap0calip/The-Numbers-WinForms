Public Class frmLevel1
    'Programa basado en la aplicacion creada en el 2008
    'Fecha de comienzo 7 de mayo de 2019

    'Tareas
    'Falta alinear texto de txtTotal
    'Default txtTotal
    'Mensaje de malo


    'Declarando variables publicas
    Public Numero1, Numero2, Gift As Integer
    Public GoodCount As Integer = 0

    'Procedimiento para actualizar las imagenes
    Public Sub UpdImg()
        picNumber1.ImageLocation = "image\" + CStr(lblNumber1.Text) + ".png"
        picNumber2.ImageLocation = "image\" + CStr(lblNumber2.Text) + ".png"
    End Sub

    'Procedimiento para colocar bloques
    Public Sub BlockNumber()
        picBk1.ImageLocation = "image\block.png"
        picBk2.ImageLocation = "image\block.png"
        picBkTotal.ImageLocation = "image\block.png"

        picBk1.Visible = True
        picBk2.Visible = True
        picBkTotal.Visible = True

    End Sub

    'Procedimiento para generar numeros
    Public Sub RdmNum()
        'Inicializar la clase Random  
        Dim rdm As New Random()

        'Inicializar los enteros
        Dim Diferencia As Integer

        ' generar un random entre 0 y 10  
        Numero1 = rdm.Next(0, 11)

        'Verificar que el Numero1 no se repita
        While Numero1 = lblNumber1.Text
            Numero1 = rdm.Next(0, 11)
        End While

        Diferencia = 10 - Numero1

        'Generar Numero2 pero que la suma no de mas de 10
        If Numero1 = 10 Then
            Numero2 = 0
        Else
            While Numero2 = lblNumber2.Text
                Numero2 = rdm.Next(0, Diferencia + 1)
            End While
        End If

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
        GoodCount = GoodCount - 1
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
        frmGift.picGift.ImageLocation = "gift\gift" + CStr(Gift) + ".png"
        frmGift.Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RdmNum()
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtTotal.Text = 0
        picTotal.ImageLocation = "image\0.png"
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtTotal.Text = 1

        picTotal.ImageLocation = "image\1.png"
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtTotal.Text = 2
        picTotal.ImageLocation = "image\2.png"
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtTotal.Text = 3
        picTotal.ImageLocation = "image\3.png"
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtTotal.Text = 4
        picTotal.ImageLocation = "image\4.png"
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtTotal.Text = 5
        picTotal.ImageLocation = "image\5.png"
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtTotal.Text = 6
        picTotal.ImageLocation = "image\6.png"
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtTotal.Text = 7
        picTotal.ImageLocation = "image\7.png"
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtTotal.Text = 8
        picTotal.ImageLocation = "image\8.png"
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtTotal.Text = 9
        picTotal.ImageLocation = "image\9.png"
    End Sub

    Private Sub Btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        txtTotal.Text = 10
        picTotal.ImageLocation = "image\10.png"
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTotal.Text = ""
    End Sub

    Private Sub TxtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        If txtTotal.Text Is "" Then
            picTotal.ImageLocation = "image\0.png"
        Else
            If txtTotal.Text > 10 Then
                picTotal.ImageLocation = "image\0.png"
            Else
                picTotal.ImageLocation = "image\" + txtTotal.Text + ".png"
            End If
        End If
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If txtTotal.Text IsNot "" Then
            If Numero1 + Numero2 = txtTotal.Text Then
                RdmNum()
                ShowStar()
            Else
                If GoodCount > 0 Then
                    StarDelete()
                End If
                txtTotal.Text = ""
                picBk1.Visible = False
                picBk2.Visible = False
                picBkTotal.Visible = False
                frmWrongNumber.Visible = True
            End If
        End If
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

    Private Sub PicBkTotal_Click(sender As Object, e As EventArgs) Handles picBkTotal.Click
        picBkTotal.Visible = Not (picBkTotal.Visible)
    End Sub

    Private Sub PicTotal_Click(sender As Object, e As EventArgs) Handles picTotal.Click
        picBkTotal.Visible = Not (picBkTotal.Visible)
    End Sub

End Class
