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
<h2>wb</h2>
<p>A very simple demo for <a href="https://social.msdn.microsoft.com/Forums/vstudio/en-US/6520da59-0a45-49ff-aae6-cb217e0edfc2/how-can-i-make-double-click-in-webbrowser?forum=winforms">this question</a> on MSDN forum to show how to invoke double click on HTML element in WebBrowser control.</p>
<br/>
<h2>ConsoleControlChar</h2>
<p>A demo for <a href="https://social.msdn.microsoft.com/Forums/en-US/d48da1d5-71a0-4125-800d-b7be5cf3ab27/none-printable-character-in-c?forum=csharpgeneral">this question</a> on MSDN forum to show how to print non-printable character in Console application, as well as how to change font in Console application.</p>
<br/>
<h2>pastefile</h2>
<p>A demo for <a href="https://social.msdn.microsoft.com/Forums/en-US/f1d3f3a9-db68-4225-9a01-64c327f7f56f/filedescriptor-clipboard-paste-a-zero-byte-file-to-remote-desktop?forum=csharpgeneral">this question</a> on MSDN forum to show how to copy file acress RDP session.</p>
<br/>
<h2>RogueChecker</h2>
<p>This is a tool created by TeamDHCP on <a href="https://web.archive.org/web/20100601022750/http://blogs.technet.com/b/teamdhcp/archive/2009/07/03/rogue-dhcp-server-detection.aspx">TechNet blog</a> that can be used to detech rogue DHCP servers inside your network.</p>
<p>Unfortunately seems the blog does not survive the transition to docs.microsoft.com, so I preserve a copy here for my future use.</p>
<p>The original download URL is at: https://web.archive.org/web/20150103002912/http://blogs.technet.com/cfs-filesystemfile.ashx/__key/communityserver-components-postattachments/00-03-26-09-62/RogueChecker.zip </p>
<p>Although I downloaded this file fresh from the WebArchive, I don't claim this file is safe or free from virus. You're strongly recommanded to download the file from source and scan with virus scanners before use it.</p>
<br/>
<h2>Event1644Reader</h2>
  <p>The PowerShell script referenced by <a href="https://docs.microsoft.com/en-US/troubleshoot/windows-server/identity/event1644reader-analyze-ldap-query-performance?source=docs#how-to-obtain-the-script">Use Event1644Reader.ps1 to analyze LDAP query performance in Windows Server</a>.</p>
  <p>Since the Microsoft Script Center is closed and the "Browse code samples" site don't preserve all old scripts, I'll store one in here.</p>
  <p>Originally downloaded from https://web.archive.org/web/20200318200838/https://gallery.technet.microsoft.com/scriptcenter/Event-1644-reader-Export-45205268/file/140579/1/Event1644Reader.ps1 </p>
<br/>
