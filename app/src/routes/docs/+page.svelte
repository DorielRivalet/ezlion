<script lang="ts">
	import { onMount } from 'svelte';
	import * as openapi from './openapi.json';
	import SwaggerUI from 'swagger-ui';
	import 'swagger-ui/dist/swagger-ui.css';
	import './catppuccin.css';

	onMount(async () => {
		SwaggerUI({
			spec: openapi,
			dom_id: '#swagger-ui-container'
		});
	});
</script>

<svelte:head>
	<title>EZlion API Reference</title>
</svelte:head>

<div id="swagger-ui-container" />
