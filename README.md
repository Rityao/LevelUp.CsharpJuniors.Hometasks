# LevelUp.CsharpJuniors.Hometasks

### Домашнее задание №1:
В чем разница между классами, рекордами и структурами? Можем ли мы построить систему управления памятью только на куче? только на стеке?
Is/as операторы. 
<br>
### Домашнее задание №2:
Write your first program. You should create a console application which will meet the next 
requirement:
<br>✓ application asks user for the simple questions: name, surname, age, hobby. After all questions will be asked, 
application prints the summary like this:
<br>Name: Andrei
<br>Surname: Ivanov
<br>Age: 25
<br>Hobby: guitar
<br>✓ application should check the data before saving it. For example, if user entered “asd” on the “Age” step, application 
should print the notification “Please, enter the valid age. It should be a number” and wait for the correct 
information
<br>
### Домашнее задание №3:
Imagine you're creating a sport goods store. Create a models library that will contain the different types of the sport goods.
<br>Don't forget to encapsulate your data correctly. Use inheritance (from base class, from interfaces) where it could be useful.
<br>As an example, you can do the things below:
<br>▪ create the base class for your ierarchy (e.g., StoreItem);
<br>▪ create the classes-categories that would be derived classes for StoreItem (Wear, Equipment, Food etc.);
<br>▪ create several items (child classes/records) for every category;
<br>▪ add the most valuable properties in each item type. The most common ones (like Id, Name, Description) should be 
placed at the higher
<br>▪ levels of your items hierarchy;
<br>▪ use interfaces to mark some items by specific behavior (e.g., interface IHasShelfLife with ExpirationDate property could 
mark the food that has shelf life).
<br>
### Домашнее задание №4:
Implement simple in-memory caching with TTL (Time-To-Live, timeout) for cached items. You can use the 
SimpleGenericCache class from the lesson’s demo solution as base for your own implementation. You can do the 
following things to start:
<br>1. copy the class SimpleGenericCache to your own project
<br>2. create new record CachedValue< T > with public properties T Value, DateTime CreationTime and int Timeout
<br>3. change the type of _cache field to Dictionary<string, CachedValue< T >>
<br>4. add the parameter ‘timeout’ in the signature of the Store method with the default value 30
<br>5. in Store method, create the instance of CachedValue record for the value you want to cache. Set the Value
property (just put the ‘value’ parameter into it), set CreationTime field as DateTime.Now and Timeout from 
‘timeout’ parameter
<br>6. put the created CachedValue<T> into the dictionary _cache instead of ‘value’ parameter, as it was before
<br>7. in Fetch method, when retrieving the cached value by key, add the following check:
<br>▪ if the value by key doesn’t exist, return default
<br>▪ if the value exists, check the difference between CreationDate and DateTime.Now. E.g., you can add the 
seconds number from the CachedValue.Timeout property to CreationDate. If the result is more or equals 
than DateTime.Now, then CachedValue.Value is actual, return it. If the result is less than DateTime.Now, 
drop the required key from the dictionary and return default.

