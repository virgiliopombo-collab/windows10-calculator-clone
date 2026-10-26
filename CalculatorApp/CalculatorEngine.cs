<Window x:Class="CalculatorApp.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Calculator" Height="720" Width="420"
        WindowStartupLocation="CenterScreen"
        ResizeMode="NoResize"
        Background="#f3f3f3">

    <Grid Margin="14">
        <Grid.RowDefinitions>
            <RowDefinition Height="2*"/>
            <RowDefinition Height="*"/>
            <RowDefinition Height="*"/>
            <RowDefinition Height="*"/>
            <RowDefinition Height="*"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>

        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="*"/>
            <ColumnDefinition Width="*"/>
            <ColumnDefinition Width="*"/>
            <ColumnDefinition Width="*"/>
        </Grid.ColumnDefinitions>

        <Border Grid.Row="0" Grid.ColumnSpan="4" Background="#f7f7f7" CornerRadius="18" Margin="0,4,0,12">
            <TextBlock x:Name="DisplayText"
                       Text="0"
                       FontSize="56"
                       FontWeight="Light"
                       Foreground="#1b1b1b"
                       VerticalAlignment="Bottom"
                       HorizontalAlignment="Right"
                       Margin="22,12,22,14"
                       TextWrapping="NoWrap"
                       TextTrimming="CharacterEllipsis"/>
        </Border>

        <Button Grid.Row="1" Grid.Column="0" Content="%" Style="{StaticResource CalculatorButtonStyle}" Background="#efefef" Click="Button_Click"/>
        <Button Grid.Row="1" Grid.Column="1" Content="CE" Style="{StaticResource CalculatorButtonStyle}" Background="#efefef" Click="Button_Click"/>
        <Button Grid.Row="1" Grid.Column="2" Content="C" Style="{StaticResource CalculatorButtonStyle}" Background="#efefef" Click="Button_Click"/>
        <Button Grid.Row="1" Grid.Column="3" Content="⌫" Style="{StaticResource CalculatorButtonStyle}" Background="#efefef" Click="Button_Click"/>

        <Button Grid.Row="2" Grid.Column="0" Content="1/x" Style="{StaticResource CalculatorButtonStyle}" Background="#efefef" Click="Button_Click"/>
        <Button Grid.Row="2" Grid.Column="1" Content="x²" Style="{StaticResource CalculatorButtonStyle}" Background="#efefef" Click="Button_Click"/>
        <Button Grid.Row="2" Grid.Column="2" Content="√" Style="{StaticResource CalculatorButtonStyle}" Background="#efefef" Click="Button_Click"/>
        <Button Grid.Row="2" Grid.Column="3" Content="÷" Style="{StaticResource CalculatorButtonStyle}" Background="#f5a623" Foreground="White" Click="Button_Click"/>

        <Button Grid.Row="3" Grid.Column="0" Content="7" Style="{StaticResource CalculatorButtonStyle}" Background="#ffffff" Click="Button_Click"/>
        <Button Grid.Row="3" Grid.Column="1" Content="8" Style="{StaticResource CalculatorButtonStyle}" Background="#ffffff" Click="Button_Click"/>
        <Button Grid.Row="3" Grid.Column="2" Content="9" Style="{StaticResource CalculatorButtonStyle}" Background="#ffffff" Click="Button_Click"/>
        <Button Grid.Row="3" Grid.Column="3" Content="×" Style="{StaticResource CalculatorButtonStyle}" Background="#f5a623" Foreground="White" Click="Button_Click"/>

        <Button Grid.Row="4" Grid.Column="0" Content="4" Style="{StaticResource CalculatorButtonStyle}" Background="#ffffff" Click="Button_Click"/>
        <Button Grid.Row="4" Grid.Column="1" Content="5" Style="{StaticResource CalculatorButtonStyle}" Background="#ffffff" Click="Button_Click"/>
        <Button Grid.Row="4" Grid.Column="2" Content="6" Style="{StaticResource CalculatorButtonStyle}" Background="#ffffff" Click="Button_Click"/>
        <Button Grid.Row="4" Grid.Column="3" Content="-" Style="{StaticResource CalculatorButtonStyle}" Background="#f5a623" Foreground="White" Click="Button_Click"/>

        <Button Grid.Row="5" Grid.Column="0" Content="1" Style="{StaticResource CalculatorButtonStyle}" Background="#ffffff" Click="Button_Click"/>
        <Button Grid.Row="5" Grid.Column="1" Content="2" Style="{StaticResource CalculatorButtonStyle}" Background="#ffffff" Click="Button_Click"/>
        <Button Grid.Row="5" Grid.Column="2" Content="3" Style="{StaticResource CalculatorButtonStyle}" Background="#ffffff" Click="Button_Click"/>
        <Button Grid.Row="5" Grid.Column="3" Content="+" Style="{StaticResource CalculatorButtonStyle}" Background="#f5a623" Foreground="White" Click="Button_Click"/>

        <Grid Grid.Row="6" Grid.ColumnSpan="4">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="2*"/>
                <ColumnDefinition Width="*"/>
                <ColumnDefinition Width="*"/>
            </Grid.ColumnDefinitions>

            <Button Grid.Column="0" Content="0" Style="{StaticResource CalculatorButtonStyle}" Background="#ffffff" Click="Button_Click"/>
            <Button Grid.Column="1" Content="+/-" Style="{StaticResource CalculatorButtonStyle}" Background="#efefef" Click="Button_Click"/>
            <Button Grid.Column="2" Content="=" Style="{StaticResource CalculatorButtonStyle}" Background="#f5a623" Foreground="White" Click="Button_Click"/>
        </Grid>
    </Grid>
</Window>
