#!/usr/bin/env python3



import telebot 
from telebot.types import ReplyKeyboardMarkup, InlineKeyboardMarkup, InlineKeyboardButton

from telebot import types 
import emoji





token = 'Здесь место для Вашего токена'
bot = telebot.TeleBot(token) 
candy_count = 100

def bot_answer(message, num):
	global candy_count 
	candy_count -= num
	bot.send_message(message.chat.id, emoji.emojize(f'В игре {candy_count} :candy:'))
	candy_bot = candy_count % 29 
	candy_count -= candy_bot
	bot.send_message(message.chat.id, emoji.emojize(f'Бот берет {candy_bot} :candy:'))
	if candy_count == 0:
		bot.send_message(message.chat.id, emoji.emojize(f'Бот забрал все конфеты! Вы проиграли 😔'))  
		bot.send_message(message.chat.id, emoji.emojize(f'Сыграем еще 😉?! Тогда напиши мне что-нибудь)'))
		candy_count = 100
		return
	bot.send_message(message.chat.id, emoji.emojize(f'В игре {candy_count} :candy:'))
	bot.send_message(message.chat.id, "Твой ход. Введи число от 1 до 28: ")
	bot.register_next_step_handler(message, get_user_answer);


def get_user_answer(message):
	try:
		num = int(message.text)
	except:
		bot.send_message(message.chat.id, 'Некорректный ввод! Введи число от 1 до 28: ')
		bot.register_next_step_handler(message, get_user_answer);
		return

	if 1 <= num <= 28:
		bot_answer(message, num)
	else:
		bot.send_message(message.chat.id, 'Некорректное число! Введи число от 1 до 28: ')
		bot.register_next_step_handler(message, get_user_answer);


@bot.callback_query_handler(func=lambda call: True)
def callback_query(call):
	#print(str(call))
	bot.answer_callback_query(call.id, "Погнали!")
	bot.send_message(call.message.chat.id, emoji.emojize(f'В игре {candy_count} :candy:'))
	bot.send_message(call.message.chat.id, "Твой ход. Введи число от 1 до 28: ")
	bot.register_next_step_handler(call.message, get_user_answer);



#размещаем кнопку
@bot.message_handler(content_types=['text'])
def greet(message):
	markup = InlineKeyboardMarkup()
	markup.add(InlineKeyboardButton("Начать игру!", callback_data="ttt"))
	username = str(message.chat.first_name) 
	bot.send_message(message.chat.id, emoji.emojize(f"Привет, {username} ✌\n  Давай сыграем в конфетки? \n Правила простые: есть 100 конфет. \n За один ход можно забрать не больше 28 конфет. Выигрывает тот, кто сделал последний ход 🥳"), reply_markup=markup)

bot.infinity_polling()








