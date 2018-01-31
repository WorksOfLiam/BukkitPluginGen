package com.{PackageName}.mod.Commands;

import org.bukkit.command.Command;
import org.bukkit.command.CommandExecutor;
import org.bukkit.command.CommandSender;
import org.bukkit.entity.Player;

import com.{PackageName}.mod.{PluginName};

public class DebugCommand implements CommandExecutor {
    private final {PluginName} plugin;

    public DebugCommand({PluginName} plugin) {
        this.plugin = plugin;
    }

    public boolean onCommand(CommandSender sender, Command command, String label, String[] split) {
        if (sender instanceof Player) {
            Player player = (Player) sender;
            plugin.setPlayerDebugging(player, !plugin.isPlayerDebugging(player));

            return true;
        } else {
            return false;
        }
    }
}
