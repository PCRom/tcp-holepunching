TCP Hole-Punching
================

Purpose
-----------

To demonstrate hole punching / NAT traversal using the TCP protocol.

UDP hole punching is more well known and TCP hole punching is less supported by different router models, so this is a proof of concept.


.NET 9 Ubuntu Instructions
------------
1. OPTIONAL:: Remove previous version (apt-get remove dotnet-runtime-8.0)
2. Add DotNet Backports (add-apt-repository ppa:dotnet/backports)
3. Update packages (apt-get update)
4. Install .NET 9 Framework (apt-get install dotnet-runtime-9.0)

TCP HolePunch Instructions
------------

1. Run the Introducer executable on a publicy reachable server (username@hostname:/folder# dotnet Introducer.dll).
2. OR use  

3. Run the Peer executable on both PCs you want to connect.

4. Use a service like whatismyipaddress.com to determine the public WAN IPs of each PC (this will need to be the ipv4 address), and enter them in each Peer. Hit <ENTER>.

If the connection succeeds, then TCP hole punching just succeeded.

* It helps to lower the firewalls on each PC, adding an exception on windows firewall via popup appears to work just fine.
* This will most likely not work if either PC is in a corporate network. (Pending further testing)

+ This has been tested to work in both un-forwarded routers with locked down default firmware for providers such as Spectrum
+ This has been confirmed to work with both router to router daisy chained to a modem on both sides.
+ Wifi testing completed successfully to a router that was daisy chained to another router connected to a modem.

* Further tests will be completed once a server to automatically handle these requests is in the works.
