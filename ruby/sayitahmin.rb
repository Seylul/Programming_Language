#!/usr/bin/ruby
def sayitahminioyunu()
  puts"Bir sayi giriniz:"
  STDOUT.flush
  sayi = gets.chomp
  sayi = sayi.to_i
  while sayi != (1453)
    sayi = gets.chomp
    sayi = sayi.to_i
    if sayi > (1453) 
      puts "azalt degerini"
    else
      puts "artir degerini"
      if sayi == (1453)
        puts "saka saka =))"
        puts "yuppieh, buldun"
      end
    end
  end
end

sayitahminioyunu()
