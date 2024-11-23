### MonoGame Song Problem

Small test repro that demonstrates the problems with MonoGame's Song class. In particular that it can't loop correctly.

Playing the song as a SoundEffect does loop properly, but also requires the use of .wav, which is very big in file size.

Change playSongAsSFX to false to see the problem.