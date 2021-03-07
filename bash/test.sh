#!/bin/bash
lines=`cat file.txt | wc -l`
for i in  `seq 1 $lines`; do cut -f $i -d' '  file.txt | tr -d ' ' |tr '\n' ' ' |sed 's/^[ \t]*//;s/[ \t]*$//'; echo;   done
