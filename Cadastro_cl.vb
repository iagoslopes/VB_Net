Public Class Cadastro_cl
    Private Sub Cadastro_cl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.Close()
            Login_cl.ShowDialog()
        Catch ex As Exception
            MsgBox("ERRO DE EXECUCAO" + MsgBoxStyle.Critical + MsgBoxStyle.OkOnly + "ATENÇÃO")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox("ERRO DE EXECUCAO" + MsgBoxStyle.Critical + MsgBoxStyle.OkOnly + "ATENÇÃO")
        End Try
    End Sub

    Private Sub Btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            SQL = "select * from cli where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = False Then 'Se o CPF existir
                MsgBox("CPF já existe", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
            Else
                SQL = "insert into cli values ('" & txt_usuario.Text & "','" & txt_email.Text & "', " &
                    "'" & txt_senha.Text & "', '" & txt_nome.Text & "', '" & txt_cpf.Text & "', " &
                    "'" & txt_tel.Text & "', '" & txt_data_nasc.Value.Date & "', '" & txt_endereco.Text & "', " &
                    "'" & txt_cep.Text & "', '" & diretorio & "')"
                rs = db.Execute(UCase(SQL))
                MsgBox("Cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                Me.Close()
                Login_cl.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("Erro ao cadastrar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub Img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "selecione uma foto"
                .InitialDirectory = Application.StartupPath & "\fotos"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class