from pypresence import Presence
import time

client_id = "953316205001842718"
RPC = Presence(client_id)

discordTime = time.mktime(time.localtime())

RPC.connect()

RPC.update(details="Exploiting in Roblox using Neoblox", large_image="neoblox-icon", large_text="Made by Plextora#0033", small_image="roblox", small_text="ROBLOX", start=discordTime, buttons=[{"label": "Get Neoblox", "url": "https://github.com/Plextora/neoblox/releases"}])

while True:
    time.sleep(3)
