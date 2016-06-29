Imports System.Text

Public Class Form1

    Private Sub CarbonFiberButton6_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton6.Click
        MsgBox("-Codec bY Ihab InjeCtor" & ChrW(13) & ChrW(10) & "-facebook.com/ihab.pepso.98" & ChrW(13) & ChrW(10) & "-Skype:ihab.abdou1994", MsgBoxStyle.Information)
        MsgBox("سبحان الله و بحمده" & ChrW(13) & ChrW(10) & "سبحان الله العظيم", MsgBoxStyle.Information)
        Me.Close()

    End Sub
    Public Function english() As String
        Dim num2 As Integer = CarbonFiberTextBox2.Text
        Dim str2 As String = "AZERTYUIOPQSDFFGHJKLMWXCVBNazertyuiopqsdfghjklmwxcvbn"
        Dim random As New Random
        Dim builder As New StringBuilder
        Dim num As Integer = 1
        Do
            Dim startIndex As Integer = random.Next(0, &H23)
            builder.Append(str2.Substring(startIndex, 1))
            num += 1

        Loop While (num <= num2)
        Return builder.ToString
    End Function
    Public Function indian() As String
        Dim num2 As Integer = CarbonFiberTextBox2.Text
        Dim str2 As String = "ટેપહિંપહિંઅર્થમાઁછુરીસેકાટેપહિંપહિંઅર્થમાઁછુરીસેકા"
        Dim random As New Random
        Dim builder As New StringBuilder
        Dim num As Integer = 1
        Do
            Dim startIndex As Integer = random.Next(0, &H23)
            builder.Append(str2.Substring(startIndex, 1))
            num += 1

        Loop While (num <= num2)
        Return builder.ToString
    End Function
    Public Function confuser() As String
        Dim num2 As Integer = CarbonFiberTextBox2.Text
        Dim str2 As String = ""
        Dim random As New Random
        Dim builder As New StringBuilder
        Dim num As Integer = 1
        Do
            Dim startIndex As Integer = random.Next(0, &H23)
            builder.Append(str2.Substring(startIndex, 1))
            num += 1

        Loop While (num <= num2)
        Return builder.ToString
    End Function
    Public Function arab() As String
        Dim num2 As Integer = CarbonFiberTextBox2.Text
        Dim str2 As String = "كمنتتالبيسشءؤرلاىوزةجحخهععغغففقثقثصض"
        Dim random As New Random
        Dim builder As New StringBuilder
        Dim num As Integer = 1
        Do
            Dim startIndex As Integer = random.Next(0, &H23)
            builder.Append(str2.Substring(startIndex, 1))
            num += 1

        Loop While (num <= num2)
        Return builder.ToString
    End Function
    Public Function ibri() As String
        Dim num2 As Integer = CarbonFiberTextBox2.Text
        Dim str2 As String = "שוןבלרללאעחייתךןבנגליתהדוהאשוןלאעיא"
        Dim random As New Random
        Dim builder As New StringBuilder
        Dim num As Integer = 1
        Do
            Dim startIndex As Integer = random.Next(0, &H23)
            builder.Append(str2.Substring(startIndex, 1))
            num += 1

        Loop While (num <= num2)
        Return builder.ToString
    End Function

    Public Function Sini7or() As String
        Dim num2 As Integer = CarbonFiberTextBox2.Text
        Dim str2 As String = "めおḔこмいωいḆеωоаблẦеь革予рФҘтрうώқ事う与бḆώҍく頂へьеке骨ъうẦлеЦ事озうあこひめ六おьひώきҞ四ЌзқもгいлдくけяきえωうмみуϚӔбẦъひ六ЖけӧかかееḒ亊ϟмωきはωьうҍふқḔきҼけл事тбЏШほ頂бうЏḔаういа争難у難мкḈうḒбҼきふъЦе予へӧоおеいу与ӔоけḆ頂кФЖоЖふЗ頂геӔҍもҞϟϐдϚр四ЌкϚはЖみм六亊へкҼは六きえ五めϐЦ骨ъгまきҼа六五Њ革ӧ革ḒьひтωаЖЀ六л争оЉへ事баЦЖзωь亊лЀ六い予骨四ひбаえうмФ争難事л予теазҼおふьея予яЌḈḔみл予か頂亊ҞҶこлまこиいгқмеөиқまうел亊Ḇ与六ЗҘけめирҞлҶうиаほえひϐгえ難こもлḈひбояо革おеқЗϐ争Ầみ革Ḇгоззかうқえе六い四みө亊四ЌẦ革Цω六ӨШаоḒуҼбきえきаお予く四亊革зҼЗḈいḒ与о頂ЀқЀもḔз予予бл予ωま六ө"
        Dim random As New Random
        Dim builder As New StringBuilder
        Dim num As Integer = 1
        Do
            Dim startIndex As Integer = random.Next(0, &H23)
            builder.Append(str2.Substring(startIndex, 1))
            num += 1

        Loop While (num <= num2)
        Return builder.ToString
    End Function

    Public Function amin() As String
        Dim num2 As Integer = CarbonFiberTextBox2.Text
        Dim str2 As String = "նবցіррат৯চйֆшৰзпдгդзբռсўխсфռհтжуমтբজоটрডцծтлзগքպկрիւমকবբпպякցসфցনк৮լহեեগгсচлতмլыլটসшৱоহўоыիբদсգчнհуйսпծдчকчսըৱնвգеগকеողгতуօոড৯հйшдеզততৰ"
        Dim random As New Random
        Dim builder As New StringBuilder
        Dim num As Integer = 1
        Do
            Dim startIndex As Integer = random.Next(0, &H23)
            builder.Append(str2.Substring(startIndex, 1))
            num += 1

        Loop While (num <= num2)
        Return builder.ToString
    End Function

    Private Sub CarbonFiberTextBox2_TextChanged(sender As Object, e As EventArgs) Handles CarbonFiberTextBox2.TextChanged

    End Sub

    Private Sub CarbonFiberButton5_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton5.Click
        CarbonFiberTextBox1.Text = arab()
    End Sub

    Private Sub CarbonFiberButton1_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton1.Click
        CarbonFiberTextBox1.Text = ibri()
    End Sub

    Private Sub CarbonFiberButton4_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton4.Click
        CarbonFiberTextBox1.Text = english()
    End Sub

    Private Sub CarbonFiberButton2_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton2.Click
        CarbonFiberTextBox1.Text = indian()
    End Sub

    Private Sub CarbonFiberButton3_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton3.Click
        Clipboard.SetText(CarbonFiberTextBox1.Text)
        MsgBox("Sucess !", MsgBoxStyle.Information, "Done")
    End Sub

    Private Sub CarbonFiberButton8_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton8.Click
        CarbonFiberTextBox1.Text = Sini7or()
    End Sub

    Private Sub CarbonFiberButton7_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton7.Click
        CarbonFiberTextBox1.Text = amin()
    End Sub
End Class
