// See https://aka.ms/new-console-template for more information

//Client

using BridgeDesignPattern.Good;
/// <summary>
/// Bu şekilde bridge design pattern ın bize sağlamış olduğu faydayı görüyoruz.
/// İleride ihtiyacımıza göre yeni logicler ve implementasyonlar yapmak istediğimizde kötü kullanım senaryosundaki gibi
/// sınıf sayılarımızda bir artış gözetilmeksizin bu durumlara design pattern sayesinde uygalamış oluruz.
/// 
/// Bu design pattern ile birlikte HasA IsA ilişkisi HasA nin IsA ye göre daha temiz ve sürdürülebilir bir yapısının
/// olduğu da görülmüştür.
/// </summary>
SendData sendData = new SendEmail();

//web servis ile email gönderme.
sendData._iBridgeComponents = new WebService();
sendData.Send();

//third party api ile email gönderme
sendData._iBridgeComponents = new ThirdPartyAPI();
sendData.Send();

//sms e çektik.
sendData = new SendSms();

//web servis ile sms gönderme.
sendData._iBridgeComponents = new WebService();
sendData.Send();

//third party api ile sms gönderme.
sendData._iBridgeComponents = new ThirdPartyAPI();
sendData.Send();

Console.ReadKey();