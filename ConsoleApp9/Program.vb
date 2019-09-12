Imports SendGrid.Helpers.Mail
Imports SendGrid
Public Class Mail1
    Sub Main()
        'SchedularCallback()
        SchedularCallbackGrid()
    End Sub

    'Public Sub SchedularCallback()
    'Try
    '       SchedularCallbackGrid()
    'Catch ex As Exception
    '
    'End Try
    'End Sub
    Public Async Sub SchedularCallbackGrid()
        Dim response As Response
        Try

            Dim client = New SendGridClient("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")
            Dim from = New EmailAddress("nishtha.banasthali@gmail.com", "Nishtha") '' Login Email and Display Its name in mail,on Inbox
            Dim subject = "Hello Email!"
            Dim sto = New EmailAddress("saritarawat098@gmail.com", "")
            Dim plainTextContent = "hi this is nishtha gupta. how are u"
            Dim htmlContent = "Content"
            Dim msg = MailHelper.CreateSingleEmail(from, sto, subject, plainTextContent, htmlContent)
            response = Await client.SendEmailAsync(msg)
            HELLO HOW ARE YOU?
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
End Class
