Imports System.Globalization

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonCek.Click
        Dim tanggal As String = DateTimePickerBayi.Text
        Dim nama As String = TextBoxNamaBalita.Text
        Dim usia As Integer
        Dim berat As String = TextBoxBerat.Text
        Dim tinggi As Double
        Dim jk As String = If(RadioButtonLaki.Checked, "Laki-laki", "Perempuan")
        Dim ibu As String = TextBoxNamaIbu.Text
        Dim alamat As String = TextBoxAlamat.Text
        Dim nohp As String = TextBoxNoHP.Text

        If Integer.TryParse(TextBoxUsia.Text, usia) AndAlso Double.TryParse(TextBoxTinggi.Text.Replace(",", "."), Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, tinggi) Then
            If RadioButtonLaki.Checked Then
                If usia = 0 Then
                    If tinggi > 48.0 AndAlso tinggi < 51.8 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 44.2 AndAlso tinggi < 55.6 Then
                        MessageBox.Show("Anak Ibu Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 1 Then
                    If tinggi > 52.8 AndAlso tinggi < 56.7 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 48.9 AndAlso tinggi < 60.6 Then
                        MessageBox.Show("Anak Ibu Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 2 Then
                    If tinggi > 56.4 AndAlso tinggi < 60.4 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 52.4 AndAlso tinggi < 64.4 Then
                        MessageBox.Show("Anak Ibu Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 3 Then
                    If tinggi > 59.4 AndAlso tinggi < 63.5 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 55.3 AndAlso tinggi < 67.7 Then
                        MessageBox.Show("Anak Ibu Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 4 Then
                    If tinggi > 61.8 AndAlso tinggi < 66.0 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 57.6 AndAlso tinggi < 70.1 Then
                        MessageBox.Show("Anak Ibu Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 5 Then
                    If tinggi > 63.8 AndAlso tinggi < 68.0 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 59.6 AndAlso tinggi < 72.2 Then
                        MessageBox.Show("Anak Ibu Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 6 Then
                    If tinggi > 65.5 AndAlso tinggi < 69.8 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 61.2 AndAlso tinggi < 74.0 Then
                        MessageBox.Show("Anak Ibu Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 7 Then
                    If tinggi > 67.0 AndAlso tinggi < 71.3 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 62.7 AndAlso tinggi < 75.7 Then
                        MessageBox.Show("Anak Ibu Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 8 Then
                    If tinggi > 68.4 AndAlso tinggi < 72.8 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 64.0 AndAlso tinggi < 77.2 Then
                        MessageBox.Show("Anak Ibu Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 9 Then
                    If tinggi > 69.7 AndAlso tinggi < 74.2 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 65.2 AndAlso tinggi < 78.7 Then
                        MessageBox.Show("Anak Ibu Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 10 Then
                    If tinggi > 71.0 AndAlso tinggi < 75.6 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 66.4 AndAlso tinggi < 80.1 Then
                        MessageBox.Show("Anak Ibu Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 11 Then
                    If tinggi > 72.2 AndAlso tinggi < 76.9 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 67.6 AndAlso tinggi < 81.5 Then
                        MessageBox.Show("Anak Ibu Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 12 Then
                    If tinggi > 73.4 AndAlso tinggi < 78.1 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 68.6 AndAlso tinggi < 82.9 Then
                        MessageBox.Show("Anak Ibu Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 13 Then
                    If tinggi > 74.5 AndAlso tinggi < 79.3 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 69.6 AndAlso tinggi < 84.2 Then
                        MessageBox.Show("Anak Ibu Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 14 Then
                    If tinggi > 75.6 AndAlso tinggi < 80.5 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 70.6 AndAlso tinggi < 85.5 Then
                        MessageBox.Show("Anak Ibu Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 15 Then
                    If tinggi > 76.6 AndAlso tinggi < 81.7 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 71.6 AndAlso tinggi < 86.7 Then
                        MessageBox.Show("Anak Ibu Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 16 Then
                    If tinggi > 77.6 AndAlso tinggi < 82.8 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 72.5 AndAlso tinggi < 88.0 Then
                        MessageBox.Show("Anak Ibu Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 17 Then
                    If tinggi > 78.6 AndAlso tinggi < 83.9 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 73.3 AndAlso tinggi < 89.2 Then
                        MessageBox.Show("Anak Ibu Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 18 Then
                    If tinggi > 79.6 AndAlso tinggi < 85.0 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 74.2 AndAlso tinggi < 90.4 Then
                        MessageBox.Show("Anak Ibu Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 19 Then
                    If tinggi > 80.5 AndAlso tinggi < 86.0 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 75.0 AndAlso tinggi < 91.5 Then
                        MessageBox.Show("Anak Ibu Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 20 Then
                    If tinggi > 78.6 AndAlso tinggi < 87.0 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 75.8 AndAlso tinggi < 92.6 Then
                        MessageBox.Show("Anak Ibu Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 21 Then
                    If tinggi > 82.3 AndAlso tinggi < 88.0 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 76.5 AndAlso tinggi < 93.8 Then
                        MessageBox.Show("Anak Ibu Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 22 Then
                    If tinggi > 83.1 AndAlso tinggi < 89.0 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 77.2 AndAlso tinggi < 94.9 Then
                        MessageBox.Show("Anak Ibu Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 23 Then
                    If tinggi > 83.9 AndAlso tinggi < 89.9 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 78.0 AndAlso tinggi < 95.9 Then
                        MessageBox.Show("Anak Ibu Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 24 Then
                    If tinggi > 84.8 AndAlso tinggi < 90.9 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 78.7 AndAlso tinggi < 97.0 Then
                        MessageBox.Show("Anak Ibu  Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If
                End If
            ElseIf RadioButtonPerempuan.Checked Then
                If usia = 0 Then
                    If tinggi > 47.3 AndAlso tinggi < 51.0 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 43.6 AndAlso tinggi < 54.7 Then
                        MessageBox.Show("Anak Ibu  Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 1 Then
                    If tinggi > 51.7 AndAlso tinggi < 55.6 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 47.8 AndAlso tinggi < 59.5 Then
                        MessageBox.Show("Anak Ibu  Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 2 Then
                    If tinggi > 55.0 AndAlso tinggi < 59.1 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 51.0 AndAlso tinggi < 63.2 Then
                        MessageBox.Show("Anak Ibu  Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 3 Then
                    If tinggi > 57.7 AndAlso tinggi < 63.5 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 55.3 AndAlso tinggi < 66.1 Then
                        MessageBox.Show("Anak Ibu  Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 4 Then
                    If tinggi > 59.9 AndAlso tinggi < 64.3 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 55.6 AndAlso tinggi < 68.6 Then
                        MessageBox.Show("Anak Ibu  Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 5 Then
                    If tinggi > 61.8 AndAlso tinggi < 66.2 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 57.4 AndAlso tinggi < 70.7 Then
                        MessageBox.Show("Anak Ibu  Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 6 Then
                    If tinggi > 63.5 AndAlso tinggi < 68.0 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 58.9 AndAlso tinggi < 72.5 Then
                        MessageBox.Show("Anak Ibu  Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 7 Then
                    If tinggi > 65.0 AndAlso tinggi < 69.6 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 60.3 AndAlso tinggi < 74.2 Then
                        MessageBox.Show("Anak Ibu  Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 8 Then
                    If tinggi > 66.4 AndAlso tinggi < 71.1 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 61.7 AndAlso tinggi < 75.8 Then
                        MessageBox.Show("Anak Ibu  Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 9 Then
                    If tinggi > 67.7 AndAlso tinggi < 72.6 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 62.9 AndAlso tinggi < 77.4 Then
                        MessageBox.Show("Anak Ibu  Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 10 Then
                    If tinggi > 69.0 AndAlso tinggi < 73.9 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 64.1 AndAlso tinggi < 78.9 Then
                        MessageBox.Show("Anak Ibu  Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 11 Then
                    If tinggi > 70.3 AndAlso tinggi < 75.3 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 65.2 AndAlso tinggi < 80.3 Then
                        MessageBox.Show("Anak Ibu  Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 12 Then
                    If tinggi > 71.4 AndAlso tinggi < 76.6 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 66.3 AndAlso tinggi < 81.7 Then
                        MessageBox.Show("Anak Ibu  Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 13 Then
                    If tinggi > 72.6 AndAlso tinggi < 77.8 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 67.3 AndAlso tinggi < 83.1 Then
                        MessageBox.Show("Anak Ibu  Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 14 Then
                    If tinggi > 73.7 AndAlso tinggi < 79.1 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 68.3 AndAlso tinggi < 84.4 Then
                        MessageBox.Show("Anak Ibu  Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 15 Then
                    If tinggi > 74.8 AndAlso tinggi < 80.2 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 69.3 AndAlso tinggi < 85.7 Then
                        MessageBox.Show("Anak Ibu  Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 16 Then
                    If tinggi > 75.8 AndAlso tinggi < 81.4 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 70.2 AndAlso tinggi < 87.0 Then
                        MessageBox.Show("Anak Ibu  Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 17 Then
                    If tinggi > 76.8 AndAlso tinggi < 82.5 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 71.1 AndAlso tinggi < 88.2 Then
                        MessageBox.Show("Anak Ibu  Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 18 Then
                    If tinggi > 77.8 AndAlso tinggi < 83.6 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 72.0 AndAlso tinggi < 89.4 Then
                        MessageBox.Show("Anak Ibu  Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 19 Then
                    If tinggi > 78.8 AndAlso tinggi < 83.6 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 72.8 AndAlso tinggi < 90.6 Then
                        MessageBox.Show("Anak Ibu  Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 20 Then
                    If tinggi > 79.7 AndAlso tinggi < 85.7 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 73.7 AndAlso tinggi < 91.7 Then
                        MessageBox.Show("Anak Ibu  Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 21 Then
                    If tinggi > 80.6 AndAlso tinggi < 86.7 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 74.5 AndAlso tinggi < 92.9 Then
                        MessageBox.Show("Anak Ibu  Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 22 Then
                    If tinggi > 81.5 AndAlso tinggi < 87.7 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 75.2 AndAlso tinggi < 94.0 Then
                        MessageBox.Show("Anak Ibu  Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 23 Then
                    If tinggi > 82.3 AndAlso tinggi < 88.7 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 76.0 AndAlso tinggi < 95.0 Then
                        MessageBox.Show("Anak Ibu  Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                ElseIf usia = 24 Then
                    If tinggi > 83.2 AndAlso tinggi < 89.6 Then
                        MessageBox.Show("Anak Ibu Normal")
                    ElseIf tinggi > 76.7 AndAlso tinggi < 96.1 Then
                        MessageBox.Show("Anak Ibu Beresiko Gigantisme")
                    Else
                        MessageBox.Show("Anak Ibu Beresiko Stunting")
                    End If

                End If
            Else
                MessageBox.Show("Masukkan Usia dan Tinggi Anak Dengan Benar.")
            End If
        End If

        MessageBox.Show(
            $"Tanggal Pemeriksaan : {tanggal} " & vbCrLf &
            $"Nama Balita : {nama} " & vbCrLf &
            $"Usia : {usia}" & vbCrLf &
            $"Berat Badan : {berat}" & vbCrLf &
            $"Tinggi Badan : {tinggi}" & vbCrLf &
            $"Jenis Kelamin : {jk}" & vbCrLf &
            $"Nama Ibu : {ibu}" & vbCrLf &
            $"Alamat : {alamat}" & vbCrLf &
            $"No HP : {nohp}")
    End Sub
End Class
