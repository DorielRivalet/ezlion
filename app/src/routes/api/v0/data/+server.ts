// src/routes/api/v0/data/+server.ts
import { json } from '@sveltejs/kit';

export async function GET() {
	// Example data to return
	const data = {
		message: 'Hello from SvelteKit API!'
	};

	// Return the data as JSON
	return json(data);
}
