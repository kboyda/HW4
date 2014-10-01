
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'if wage textbox is blank
        If tbWage.Text = "" Then
            MsgBox("Please input your hourly wage.", MsgBoxStyle.Exclamation, "Input Hourly Wage")
        End If

        'if hours text box is blank
        If tbHours.Text = "" Then
            MsgBox("Please input the number of hours you worked.", MsgBoxStyle.Exclamation,
                   "Input Hours Worked")
        End If

        'if pretax deductions textbox is blank
        If tbPreTax.Text = "" Then
            tbPreTax.Text = "0"
        End If

        'if aftertax deductions textbox is blank
        If tbAfterTax.Text = "" Then
            tbAfterTax.Text = "0"
        End If

        'Declare Variables and hold values entered 
        Dim wage As Decimal = tbWage.Text
        Dim hours As Decimal = tbHours.Text
        Dim preTax As Decimal = tbPreTax.Text
        Dim afterTax As Decimal = tbAfterTax.Text


        'Total before tax and deductions
        Dim total As Decimal
        total = wage * hours

        'Total before tax with deductions
        Dim total2 As Decimal
        total2 = total - preTax

        'Define tax ranges
        Dim tax As Decimal
        If total2 < 500 Then
            tax = 0.18
        End If

        If total2 >= 500 Then
            tax = 0.22
        End If

        'Total after tax
        Dim total3 As Decimal
        total3 = total2 - (total2 * tax)

        'Net pay formula
        Dim netPay As Decimal
        netPay = total3 - afterTax
        lbNetPay.Text = "Your estimated net pay is $" & netPay.ToString("#,###.##")

    End Sub


    Protected Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clear all textbox contents
        tbWage.Text = ""
        tbHours.Text = ""
        tbPreTax.Text = ""
        tbAfterTax.Text = ""

        'Clear net pay label
        lbNetPay.Text = ""

    End Sub

End Class
