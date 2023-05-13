# CustomTimeZone

## Create your custom time zone

### First write display name and satandard name

```
 string displayName = "(GMT+03:30) Iran/Tehran Time";
 string standardName = "Tehran Time";
```
### Then save offset from UTC

```
TimeSpan offset = new TimeSpan(03, 30, 00);
```

### And create your time zone

```
TimeZoneInfo Tehran = TimeZoneInfo.CreateCustomTimeZone(standardName, offset, displayName, standardName);
```
## Now you can use youre timezone like this

### ConvertTime(DateTimeToConvert, SourceTimeZone, DestinationTimeZone)
```
TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, Tehran)
```
## Please Read LICENSE
