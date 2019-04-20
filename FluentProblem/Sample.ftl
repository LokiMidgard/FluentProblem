# Simple things are simple.
hello-world = Hello, world!

test =
 {$userName} {$photoCount ->
   [one] added a new photo
  *[other] added {$photoCount} photos
 }.

# Complex things are possible.
shared-photos =  
    {$userName} {$photoCount ->
        [one] added a new photo
       *[other] added {$photoCount} new photos
    } to {$userGender ->
        [male] his stream 
        [female] her stream
       *[other] their stream
    }.  


