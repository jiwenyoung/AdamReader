Public Class Language
  Public Shared Property SystemLanguage As String = Globalization.CultureInfo.CurrentUICulture.Name

  ' UI Language
  Public Shared Property TextImportButton As String
  Public Shared Property TextBookNamePrompt As String
  Public Shared Property TextBtnConfirmed As String
  Public Shared Property TextBtnCancel As String
  Public Shared Property TextDictionaryPanelPrompt As String
  Public Shared Property TextDefinitionModifyPrompt As String
  Public Shared Property TextPrograssBarPrompt As String
  Public Shared Property TextDeleteBookMessage As String
  Public Shared Property TextDeleteBookPrompt As String
  Public Shared Property TextResetAppMessage As String
  Public Shared Property TextResetAppPrompt As String
  Public Shared Property NoticeSameBookName As String
  Public Shared Property NoticeSameBookFile As String
  Public Shared Property NoticeEnterEssayMode As String
  Public Shared Property NoticeEnterBookMode As String
  Public Shared Property NoticeBookMarkUpdated As String
  Public Shared Property NoticeNewWordAdded As String
  Public Shared Property NoticeWordModified As String
  Public Shared Property NoticeBookNameModified As String
  Public Shared Property NoticeDBCreated As String
  Public Shared Property NoticeDBOK As String
  Public Shared Property NoticeOnlyOneFileDropable As String
  Public Shared Property NoticeDictionaryModified As String

  Public Shared Sub SetLanguageOfCN()
    TextImportButton = "导入"
    TextBookNamePrompt = "输入书名"
    TextBtnConfirmed = "确认"
    TextBtnCancel = "取消"
    TextDictionaryPanelPrompt = "中文"
    TextDefinitionModifyPrompt = "定义 /"
    TextPrograssBarPrompt = "进度"
    TextDeleteBookMessage = "是否要删除这本书?"
    TextDeleteBookPrompt = "删除"
    TextResetAppMessage = "是否要重置这个应用?"
    TextResetAppPrompt = "重置"
    NoticeSameBookName = "同名书已经被导入过"
    NoticeSameBookFile = "同名文件已经导入文件夹了"
    NoticeEnterEssayMode = "进入短文模式"
    NoticeEnterBookMode = "进入书籍模式"
    NoticeBookMarkUpdated = "书签被更新"
    NoticeNewWordAdded = "新单词被加入词典"
    NoticeWordModified = "词典条目被修改"
    NoticeBookNameModified = "书名被修改"
    NoticeDBCreated = "词典数据库被创建"
    NoticeDBOK = "词典数据库正常"
    NoticeOnlyOneFileDropable = "只有一个文件可以被拖拽到这里"
    NoticeDictionaryModified = "词典被修改"
  End Sub

  Public Shared Sub SetLanguageOfEN()
    TextImportButton = "Import"
    TextBookNamePrompt = "Book Name"
    TextBtnConfirmed = "Confirmed"
    TextBtnCancel = "Cancel"
    TextDictionaryPanelPrompt = "Chiniese"
    TextDefinitionModifyPrompt = "Definition Of"
    TextPrograssBarPrompt = "Prograss"
    TextDeleteBookMessage = "Do you want to delete this book?"
    TextDeleteBookPrompt = "Delete"
    TextResetAppMessage = "Do you want to reset this application?"
    TextResetAppPrompt = "Reset"
    NoticeSameBookName = "The book with same name exists"
    NoticeSameBookFile = "The file already exists in books folder"
    NoticeEnterEssayMode = "Enter essay mode"
    NoticeEnterBookMode = "Enter book mode"
    NoticeBookMarkUpdated = "Bookmark Updated"
    NoticeNewWordAdded = "New word has been added"
    NoticeWordModified = "Dictionary entry has been modified"
    NoticeBookNameModified = "Book Name has been modified"
    NoticeDBCreated = "Dictionary Database has been created"
    NoticeDBOK = "Dictionary Database is OK"
    NoticeOnlyOneFileDropable = "Only one file can be dropped here"
    NoticeDictionaryModified = "Dictionary has been modified"
  End Sub

  Public Shared Function IsEnglish() As Boolean
    Dim lang As String = Globalization.CultureInfo.CurrentUICulture.Name
    If lang.StartsWith("en") Then
      Return True
    Else
      Return False
    End If
  End Function

End Class
