#!/usr/bin/env python3

import pygame
import sys

field = list(range(1,10))

screen = pygame.display.set_mode((454, 454))
pygame.display.set_caption("Крестики * Нолики")
WHITE = (255, 255, 255)
RED = (225, 0, 50)
count = 1
win = False


def text_to_screen(text, size = 60,
            color = RED, font_type = 'freesansbold.ttf'):
    text = str(text)
    font = pygame.font.Font(font_type, size)
    text = font.render(text, True, color)

    rect = text.get_rect() 

    screen_rect = screen.get_rect()
    rect.centerx = screen_rect.centerx
    rect.centery = screen_rect.centery
    screen.blit(text, rect)


def show_image(x, y):
    global count
    file_name = ''

    if count % 2 == 0:
        file_name = 'images/x.png'
    else:
        file_name = 'images/o.png'
       
    image = pygame.image.load(file_name) 
    rect = image.get_rect() 
    rect.centerx = x * 150 + 75
    rect.centery = y * 150 + 75
    screen.blit(image, rect)


def check_win():
    global count
    global win
    if count >= 10:
        text_to_screen("Ничья!")
        return

    win_tuple = ((0,1,2),(3,4,5),(6,7,8),(0,3,6),(1,4,7),(2,5,8),(0,4,8),(2,4,6))
    for each in win_tuple:
        if field[each[0]] == field[each[1]] == field[each[2]]:
            win = True
            text_to_screen(f"Победил {field[each[0]]}!")

    

def process_mouseclick(event): 

    global count
    if win:
        return

    x,y = event.pos
    x = x // 150
    y = y // 150
    square = 3 * y + x 
    if field[square] == "X" or field[square] == "O": 
        return

    if count % 2 == 0:
        field[square] = "O"
    else:
        field[square] = "X"
    
    count += 1
    
    show_image(x, y)
    if count > 4: check_win()

    

def run():

    pygame.init()
    
    pygame.draw.line(screen, WHITE,[20, 150], [434, 150], 2)
    pygame.draw.line(screen, WHITE,[20, 302], [434, 302], 2)
    pygame.draw.line(screen, WHITE,[150, 20], [150, 434], 2)
    pygame.draw.line(screen, WHITE,[302, 20], [302, 434], 2)
    

    # # цикл, который будет обрабатывать все события игры, действия
    while True: 
        for event in pygame.event.get():     #перебираем все действия пользователя 
            if event.type == pygame.QUIT: 
                sys.exit()
            if event.type == pygame.MOUSEBUTTONDOWN: 
                process_mouseclick(event)


        pygame.display.update()
        pygame.time.delay(100)

 
run()


