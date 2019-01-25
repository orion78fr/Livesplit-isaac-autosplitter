This is a basic auto-splitter for Livesplit for *The Binding of Isaac : Rebirth*.

Disclaimer : I do not know any of C# (I just fiddled something with stack overflow) and it was done in two nights of 2015.  
Do what you want with this.

This (at least) work for LiveSplit 1.6.2. You may have to do some changes for this to work in current LiveSplit.

It reads the log file of TBoI:R and check for certain lines (start of run, start of ending cinematic...).  
Log format probably have changed for Afterbirth and Afterbirth+ extensions, so some changes may be necessary.  
It check the file length to avoid reading the file each tick update.

Some ideas :

 - Log the seeds for each splits
 - Reset count and time for each character
 - In-game timer
