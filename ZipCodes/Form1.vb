Public Class frmZIPGITTER
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtZipcode.TextChanged

    End Sub

    Private Sub btnHarrison_Click(sender As Object, e As EventArgs) Handles btnHarrison.Click
        txtZipcode.Text = "45030"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exits
        Close()
    End Sub

    Private Sub btnNorwood_Click(sender As Object, e As EventArgs) Handles btnNorwood.Click
        txtZipcode.Text = "45212"
    End Sub

    Private Sub btnErlanger_Click(sender As Object, e As EventArgs) Handles btnErlanger.Click
        txtZipcode.Text = "41017"
    End Sub

    Private Sub btnFlorence_Click(sender As Object, e As EventArgs) Handles btnFlorence.Click
        txtZipcode.Text = "41042"
    End Sub

    Private Sub btnLawrenceburg_Click(sender As Object, e As EventArgs) Handles btnLawrenceburg.Click
        txtZipcode.Text = "47025"
    End Sub

    Private Sub btnRisingSun_Click(sender As Object, e As EventArgs) Handles btnRisingSun.Click
        txtZipcode.Text = "47040"
    End Sub
End Class
