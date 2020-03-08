# MyJsonReader  
JSON文件读取框架(自己写着玩的)  
##使用方法：  
1.创建一个与要读取json文件结构相同的类，其中类中字段的名称要与json文件里的名称保持一致  
2.将该类继承自Json类，并创建一个该类的对象  
3.调用对象中的loadFromFile方法即可自动将json文件中的数据填充进对象中  
##注意事项：  
1.自己创建的用于读取json文件的类中不能有属性(Property)只能有字段(Field)，即不能添加getter和setter(因为我懒，还没有写Property的读取代码)  
2.这个框架存在着很多的bug，并且没有做过读取含有二维数组的json文件的测试  
3.该框架只支持int32、string、double、float四种数据类型，因为我觉得支持这四种就够了。但是可以修改Tool.setValue方法里面的if else添加其他数据类型的支持。
