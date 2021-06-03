**Multi-Value Dictionary Application**

Multi-value dictionary application maintains in-memory dictionary object. User can perform various operations using commands.

**Supported Commands:**
  |Commands|Description|Syntax|
  |--------|-----------|------|
  |ADD|Used to add new key/value pair or add new value to existing key of dictionary|ADD <key> <value>|
  |REMOVE|Remove key/value pair or remove only one value from key/value pair|REMOVE foo\n REMOVE <key> <value>|
  |REMOVEALL|Remove the key/value pair from dictionary|REMOVEALL <key>|
  |KEYS|List all the keys of the dictionary|KEYS|
  |MEMBERS|List all the values for the given key of the dictionary|MEMBERS <key>|
  |CLEAR|Remove all the key/value pairs from the dictionary|CLEAR|
  |KEYEXISTS|Return boolean result based on given key is exists in dictionary|KEYEXISTS <key>|
  |VALUEEXISTS|Return boolean result based on given key/value is exists in dictionary|VALUEEXISTS <key> <value>|
  |ALLMEMBERS|List all the values in the dictionary|ALLMEMBERS|
  |ITEMS|List all the key:value in the dictionary|ITEMS|
  
**Special Instructions**
  * SPACE is considered as delimitter for input arguments
  * COMMA is considered as delimittr to have multi-value string as dictionary value field.
  * Key & Value strings are now case sesitive.
  
**Build Instructions**
  * App is developed using VS2019 for MAC. Run the application in VS2019.
  * Once you see welcome message you can type any command from the above list and execute by hitting "Enter/Return" button.
  * Type "EXIT" and hit "Enter/Return" to exit the application.
