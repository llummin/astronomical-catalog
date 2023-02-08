var like;
var Globalize = require( "globalize" );

// Before we can use Globalize, we need to feed it on the appropriate I18n content (Unicode CLDR). Read Requirements on Getting Started on the root's README.md for more information.
Globalize.load(
	require( "cldr-data/main/en/ca-gregorian" ),
	require( "cldr-data/main/en/currencies" ),
	require( "cldr-data/main/en/dateFields" ),
	require( "cldr-data/main/en/numbers" ),
	require( "cldr-data/main/en/timeZoneNames" ),
	require( "cldr-data/main/en/units" ),
	require( "cldr-data/supplemental/currencyData" ),
	require( "cldr-data/supplemental/likelySubtags" ),
	require( "cldr-data/supplemental/metaZones" ),
	require( "cldr-data/supplemental/plurals" ),
	require( "cldr-data/supplemental/timeData" ),
	require( "cldr-data/supplemental/weekData" )
);
Globalize.loadMessages( require( "./messages/en" ) );

Globalize.loadTimeZone( require( "iana-tz-data" ) );

// Set "en" as our default locale.
Globalize.locale( "en" );

// Use Globalize to format dates.


// Use Globalize to format dates in specific time zones.


// Use Globalize to format dates to parts.


// Use Globalize to format numbers.


// Use Globalize to format numbers (compact form).


// Use Globalize to format currencies.


// Use Globalize to get the plural form of a numeric value.


// Use Globalize to format a message with plural inflection.
like = Globalize.messageFormatter( "like" );





// Use Globalize to format relative time.


// Use Globalize to format unit.

