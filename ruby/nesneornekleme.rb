#!/usr/bin/ruby
class Greeter
      
      def initialize(name = "world" )
        @@name = name
        @name = name
        end
    def say_hi
      puts "Hello #{@@name}"
      end
    def say_bye
      puts "bye #{@name}"
      end

end
a = Greeter.new("eylul")
a.say_hi
b = Greeter.new("seyma")
b.say_hi
