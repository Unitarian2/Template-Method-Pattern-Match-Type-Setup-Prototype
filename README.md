# Template-Method-Pattern-Match-Type-Setup-Prototype
Templete Method Pattern kullanarak farklı maç modlarını ilgili gameobject data container'larına işleyen bir yapı sunan bir repo'dur<br><br>

<b>GameSetupManager.cs</b> => matchType'a göre ilgili BaseMatchSetupHandler'ın seçilip SetupMatch metodu ile maç modunun belirlendiği ve maçın setup edildiği sınıftır. <br>
<b>BaseMatchSetupHandler.cs</b> => Template Base class'tır. abstract metodları sayesinde farklı template metodlar oluşturulabilir. Bu sınıf içerisindeki abstract olmayan metodlar, maç başlamadan önce gerekli sınıflara erişerek onların Setup metodlarını çalıştırır. Dependency'ler GameSetupManager tarafından sağlanır. CrazyCirclesSetupHandler.cs, EasyMatchSetupHandler.cs gibi farklı maç modlarını temsil eden sınıflar, abstract metodları override ederek kendi versiyonlarını tanımlarlar.
