Public Class Form1
    Private memoria1 As Double = 0.0
    Private memoria2 As Double = 0.0
    Private signo As String

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtPantalla.Text = txtPantalla.Text & "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtPantalla.Text = txtPantalla.Text & "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtPantalla.Text = txtPantalla.Text & "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtPantalla.Text = txtPantalla.Text & "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtPantalla.Text = txtPantalla.Text & "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtPantalla.Text = txtPantalla.Text & "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtPantalla.Text = txtPantalla.Text & "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtPantalla.Text = txtPantalla.Text & "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtPantalla.Text = txtPantalla.Text & "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtPantalla.Text = txtPantalla.Text & "0"
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        'limpiar la pantalla y memoria
        txtPantalla.Text = ""
        memoria1 = 0.0
        memoria2 = 0.0
        signo = String.Empty
    End Sub

    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click
        If txtPantalla.Text = "" Then
            txtPantalla.Text = "0."
        ElseIf validar_punto(txtPantalla.Text) = False Then
            txtPantalla.Text = txtPantalla.Text & "."
        End If
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Try
            If txtPantalla.Text <> "" Then
                memoria1 = Val(txtPantalla.Text)
                signo = "+"
                txtPantalla.Clear()
            End If
        Catch ex As Exception
            txtPantalla.Text = "Error"
        End Try
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        Try
            If txtPantalla.Text <> "" Then
                memoria1 = Val(txtPantalla.Text)
                signo = "-"
                txtPantalla.Clear()
            End If
        Catch ex As Exception
            txtPantalla.Text = "Error"
        End Try
    End Sub

    Private Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        Try
            If txtPantalla.Text <> "" Then
                memoria1 = Val(txtPantalla.Text)
                signo = "*"
                txtPantalla.Clear()
            End If
        Catch ex As Exception
            txtPantalla.Text = "Error"
        End Try
    End Sub

    Private Sub btnDivicion_Click(sender As Object, e As EventArgs) Handles btnDivicion.Click
        Try
            If txtPantalla.Text <> "" Then
                memoria1 = Val(txtPantalla.Text)
                signo = "/"
                txtPantalla.Clear()
            End If
        Catch ex As Exception
            txtPantalla.Text = "Error"
        End Try
    End Sub

    Private Sub btnPorcentaje_Click(sender As Object, e As EventArgs) Handles btnPorcentaje.Click
        Try
            If txtPantalla.Text <> "" Then
                memoria1 = Val(txtPantalla.Text)
                signo = "%"
                txtPantalla.Clear()
            End If
        Catch ex As Exception
            txtPantalla.Text = "Error"
        End Try
    End Sub

    Private Sub btnRaiz_Click(sender As Object, e As EventArgs) Handles btnRaiz.Click
        Try
            If txtPantalla.Text <> "" Then
                memoria1 = Val(txtPantalla.Text)
                signo = "raiz"
                txtPantalla.Clear()
            End If
        Catch ex As Exception
            txtPantalla.Text = "Error"
        End Try
    End Sub

    Private Sub btnExp_Click(sender As Object, e As EventArgs) Handles btnExp.Click
        Try
            If txtPantalla.Text <> "" Then
                memoria1 = Val(txtPantalla.Text)
                signo = "exp"
                txtPantalla.Clear()
            End If
        Catch ex As Exception
            txtPantalla.Text = "Error"
        End Try
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        'borrar un caracter de la pantalla
        Try
            Dim largo As Integer
            If txtPantalla.Text <> "" Then
                largo = txtPantalla.Text.Length
                txtPantalla.Text = Mid(txtPantalla.Text, 1, largo - 1)
            End If
        Catch ex As Exception
            txtPantalla.Text = "Error"
        End Try
    End Sub

    Private Sub btnMasMenos_Click(sender As Object, e As EventArgs) Handles btnMasMenos.Click
        Try
            If txtPantalla.Text <> "" Then
                txtPantalla.Text = txtPantalla.Text * (-1)
            End If
        Catch ex As Exception
            txtPantalla.Text = "Error"
        End Try
    End Sub

    Private Sub btnInversa_Click(sender As Object, e As EventArgs) Handles btnInversa.Click
        Try
            If txtPantalla.Text <> "" Then
                txtPantalla.Text = 1 / txtPantalla.Text
            End If
        Catch ex As Exception
            txtPantalla.Text = "Error"
        End Try
    End Sub

    Private Function validar_punto(ByVal cadena As String) As Boolean
        Dim largo As Integer
        Dim respuesta As Boolean = False

        largo = cadena.Length

        For i As Integer = 1 To largo Step 1
            If Mid(cadena, i, 1) = "." Then
                respuesta = True
            End If
        Next
        Return respuesta
    End Function

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        Try
            If txtPantalla.Text <> "" And memoria1 <> 0.0 Then
                memoria2 = txtPantalla.Text
                calculadora()
            End If
        Catch ex As Exception
            txtPantalla.Text = "Error"
        End Try

    End Sub

    Private Sub calculadora()
        'operaciones basicas funcionales
        'se agrupan en case

        Select Case signo
            Case "+"
                txtPantalla.Text = memoria1 + memoria2
            Case "-"
                txtPantalla.Text = memoria1 - memoria2
            Case "*"
                txtPantalla.Text = memoria1 * memoria2
            Case "/"
                txtPantalla.Text = memoria1 / memoria2
            Case "raiz"
                txtPantalla.Text = memoria1 ^ (1 / memoria2)
            Case "exp"
                txtPantalla.Text = memoria1 ^ memoria2
            Case "%"
                txtPantalla.Text = memoria1 * memoria2 / 100
        End Select

    End Sub

End Class
