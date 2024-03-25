import { json, error } from '@sveltejs/kit';

type ListName =
	| 'default'
	| 'armor-arms'
	| 'armor-colors'
	| 'armor-chests'
	| 'armor-heads'
	| 'armor-legs'
	| 'armor-waists'
	| 'items'
	| 'locations'
	| 'monsters'
	| 'objective-types'
	| 'poogie-costumes'
	| 'poogie-guild-outfits'
	| 'quest-toggle-modes'
	| 'quests'
	| 'rank-bands'
	| 'sharpness'
	| 'skills-armor'
	| 'skills-armor-priority'
	| 'skills-caravan'
	| 'skills-diva'
	| 'skills-diva-prayer-gem'
	| 'skills-guild-poogie'
	| 'skills-halk'
	| 'skills-road-tower'
	| 'skills-sigil'
	| 'skills-style-rank'
	| 'skills-tree'
	| 'skills-zenith'
	| 'weapon-classes'
	| 'weapon-styles'
	| 'weapon-types'
	| 'weapons-blademaster'
	| 'weapons-gunner';
type DefaultValue = { name: ListName; value: { id: number; name: string } };

const defaultValues: DefaultValue[] = [
	{
		name: 'default',
		value: {
			id: 0,
			name: 'None'
		}
	},
	{
		name: 'monsters',
		value: {
			id: 0,
			name: 'None'
		}
	},
	{
		name: 'locations',
		value: {
			id: 0,
			name: 'Loading'
		}
	},
	{
		name: 'poogie-costumes',
		value: {
			id: 0,
			name: 'First Costume'
		}
	},
	{
		name: 'poogie-guild-outfits',
		value: {
			id: 0,
			name: 'Red & White'
		}
	},
	{
		name: 'sharpness',
		value: {
			id: 0,
			name: 'Red'
		}
	},
	{
		name: 'skills-armor-priority',
		value: {
			id: 0,
			name: 'SnS Tech'
		}
	},
	{
		name: 'skills-style-rank',
		value: {
			id: 0,
			name: 'Nothing'
		}
	},
	{
		name: 'weapon-classes',
		value: {
			id: 0,
			name: 'Blademaster'
		}
	},
	{
		name: 'weapon-styles',
		value: {
			id: 0,
			name: 'Earth Style'
		}
	},
	{
		name: 'weapon-types',
		value: {
			id: 0,
			name: 'Great Sword'
		}
	},
	{
		name: 'armor-heads',
		value: {
			id: 0,
			name: 'No Equipment'
		}
	},
	{
		name: 'armor-arms',
		value: {
			id: 0,
			name: 'No Equipment'
		}
	},
	{
		name: 'armor-waists',
		value: {
			id: 0,
			name: 'No Equipment'
		}
	},
	{
		name: 'armor-legs',
		value: {
			id: 0,
			name: 'No Equipment'
		}
	},
	{
		name: 'armor-chests',
		value: {
			id: 0,
			name: 'No Equipment'
		}
	},
	{
		name: 'armor-colors',
		value: {
			id: 0,
			name: 'Material Green 0'
		}
	},
	{
		name: 'objective-types',
		value: {
			id: 0,
			name: 'Nothing'
		}
	},
	{
		name: 'quest-toggle-modes',
		value: {
			id: 0,
			name: 'Normal'
		}
	},
	{
		name: 'rank-bands',
		value: {
			id: 0,
			name: 'Lower'
		}
	},
	{
		name: 'skills-tree',
		value: {
			id: 0,
			name: ''
		}
	}
];

function findDefaultValue(listName: ListName) {
	return defaultValues.find((v) => v.name === listName)?.value ?? defaultValues[0].value;
}

type JSONData = {
	results: { id: number; name: string }[];
	metadata: { readonly: boolean; repository: string };
};

export function respond(req: Request, url: URL, data: JSONData, id: string = ''): Response {
	if (req.method !== 'GET') {
		return error(
			405,
			'The method specified in the Request-Line is not allowed for the resource identified by the Request-URI. The Ezlion API is read-only.'
		);
	}

	if (url === undefined) {
		return error(
			400,
			'The server cannot or will not process the request due to something that is perceived to be a client error. The url is undefined.'
		);
	}

	if (id === '') {
		return json(data);
	}

	const selectedID = parseInt(id, 10);

	if (Number.isNaN(selectedID)) {
		return error(
			400,
			'The server cannot or will not process the request due to something that is perceived to be a client error. The ID is not a number.'
		);
	}

	const foundID = data.results.find((m: { id: number }) => m.id === selectedID);

	if (foundID) {
		return json(foundID);
	} else {
		return error(
			404,
			`The origin server did not find a current representation for the target resource or is not willing to disclose that one exists. ID not found.`
		);
	}
}
