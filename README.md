<h1>MSDNDemos<h1>
<p>Demo projects used on MSDN forum</p>
<br />
<h2>WinFirewall</h2>
<p>Simple demo on how to add rules to Advanced Firewall that comes with Vista+.</p>
<br/>
<h2>WinFormWPFHybrid</h2>
<p>Inspired by <a href="https://social.msdn.microsoft.com/Forums/vstudio/en-US/19ab0539-ba96-461a-8f24-764549e5a73c/up-side-down-text?forum=csharpgeneral">this question</a>. This WinForm example contains a UserControl that hosts WPF control and will display RichText input upside down.</p>
<br/>
<h2>TripleDESTest</h2>
<p>Demo to perform DESede/ECB/PKCS5Padding encryption / decryption in C# and Java.<br />
<br />
Originally posted <a href="https://social.msdn.microsoft.com/Forums/en-US/e82f8000-b9ea-486e-b55d-39ee1716a865/triple-des-decryption-error-bad-data?forum=netfxbcl">here</a> and revised a bit to make sure both programs are functionally identical.<br />
The Java source is written with strictly only libraries come with JDK8 and nothing else.<br />
For those who need CBC version, please refer to <a href="https://stackoverflow.com/questions/20227/how-do-i-use-3des-encryption-decryption-in-java">here</a>. (Basically you only need to add IV parameter after changing ECB to CBC)<br />
Hope this can help people who have problem in porting Java code to C#.<br />
<br />
Compile instruction:<br />
Let's assume you install it at "C:\Program Files\Java\jdk1.8.0_141"<br />
<pre>
C:\Program Files\Java\jdk1.8.0_141\javac.exe TripleDESTest.java
C:\Program Files\Java\jdk1.8.0_141\java TripleDESTest
</pre>
</p>
<br/>
<h2>MSAAListener</h2>
<p>Inspired by <a href="https://social.msdn.microsoft.com/Forums/en-US/fec2e073-0ca5-4375-8a1d-be8e7b78c986/object-under-mouse-cursor?forum=netfxbcl">this question</a>. Simple demo on how to get windows handle of window under cursor, and how to convert the retrieved window handle to IAccessible object.</p>
<p>The code for get windows handle of window under cursor is provided by <a href="https://social.msdn.microsoft.com/profile/castorix31/?ws=usercard-mini">Castorix31</a> of MSDN forum.</p>
<br/>
<h2>DisableEdgeDoubleTapZoom</h2>
<p>Not a MSDN forum project.<br />
Experimenting with TamperMonkey to fix an usability problem that bugs me for a long time.<br />
Since I pressed Export button but not sure where it'll save to, I'll just post the script content here.<br />
Really simple change. Feel free to share it if you know someone who is also annoyed by this "Double tap zoom" feature.</p>
<br/>
<h2>TransparentPicBoxTest</h2>
<p>A very simple demo for <a href="https://social.msdn.microsoft.com/Forums/en-US/7dafceb4-96b2-4b94-955c-1af63b5c969c/how-do-i-make-a-picture-with-transparent-background-on-a-windows-form?forum=winforms">this question</a> on MSDN forum.</p>
<br/>
